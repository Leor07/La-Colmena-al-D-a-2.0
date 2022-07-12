using Amazon;
using Amazon.Rekognition;
using Amazon.Rekognition.Model;
using System;
using System.Web.UI;
namespace La_Colmena_al_Día_2._0
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (fuImagen.HasFile)
            {
                tblNoticiasTableAdapter adapter = new tblNoticiasTableAdapter();
                _ = adapter.Insert(txtTitulo.Text,
                                   "Publicado",
                                   DateTime.Now,
                                   txtDetalle.Text,
                                   fuImagen.FileName,
                                   ddlCategoria.SelectedValue);
                Amazon.Rekognition.Model.Image image = new Amazon.Rekognition.Model.Image();

                image.Bytes = new System.IO.MemoryStream(fuImagen.FileBytes);

                DetectModerationLabelsRequest detectModerationLabelsRequest = new DetectModerationLabelsRequest()

                {
                    Image = image,

                    MinConfidence = 60
                };


                //TODO: Validar imagenes

                AmazonRekognitionClient rekognitionClient = new AmazonRekognitionClient("AKIAIE5LZMZN4CR6IO5Q", "xUtzMH5IxZmuZYrc9KSN83JE+pgf5J60+FajM65J", RegionEndpoint.USEast1);
                //Moderacion

                DetectModerationLabelsResponse detectModerationLabelsResponse = rekognitionClient.DetectModerationLabels(detectModerationLabelsRequest);

                foreach (var item in detectModerationLabelsResponse.ModerationLabels)
                {
                    txtDetalle.Text = txtDetalle.Text + item.Name + "-" + item.Confidence.ToString() + "\r\n";
                }

                RecognizeCelebritiesRequest recognizeCelebritiesRequest = new RecognizeCelebritiesRequest()

                {
                    Image = image

                    //Celebridades

                };
                RecognizeCelebritiesResponse recognizeCelebritiesResponse = rekognitionClient.RecognizeCelebrities(recognizeCelebritiesRequest);

                foreach (var item in recognizeCelebritiesResponse.CelebrityFaces)

                {
                    lblCelebridad.Text = lblCelebridad.Text + item.Name + ",";
                }



                //Aplicar IA a Imagen
                DetectLabelsRequest detectLabelsRequest = new DetectLabelsRequest()

                {
                    Image = image,
                    MaxLabels = 10,
                    MinConfidence = 77F
                };

                DetectLabelsResponse detectLabelsResponse = rekognitionClient.DetectLabels(detectLabelsRequest);
                foreach (var item in detectLabelsResponse.Labels)
                {
                    lblCelebridad.Text = lblCelebridad.Text + item.Name + "-" + item.Confidence.ToString() + "\r\n";
                }
                //Imagen a Texto
                DetectTextRequest detectTextRequest = new DetectTextRequest()
                {
                    Image = image,

                };
                DetectTextResponse detectTextResponse = rekognitionClient.DetectText(detectTextRequest);
                foreach (var item in detectTextResponse.TextDetections)

                {
                    lblCelebridad.Text = lblCelebridad.Text + item.DetectedText + "-" + item.Confidence.ToString();
                }

                fuImagen.SaveAs(Server.MapPath("Imagenes") +

               @"\" + fuImagen.FileName);

                imgFoto.ImageUrl = "/Imagenes/" + fuImagen.FileName;

            }
        }
        protected void Abrir_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm2.aspx");
            /*Response.Redirect("https://localhost:44316/WebForm2.aspx");
            if (Response.IsClientConnected)
            {
                // If still connected, redirect
                // to another page. 
                Response.Redirect("WebForm2.aspx", false);
            }
            else
            {
                // If the browser is not connected
                // stop all response processing.
                Response.End();
            }*/
        }
    }

    internal class tblNoticiasTableAdapter
    {
        internal object Insert(string text1, string v, DateTime now, string text2, string fileName, string selectedValue)
        {
            throw new NotImplementedException();
        }
    }
}