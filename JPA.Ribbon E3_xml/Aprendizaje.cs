using CustomControls.RJControls;
using Microsoft.Office.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JPA.Ribbon_E3_xml
{
    public partial class Aprendizaje : MaterialSkin.Controls.MaterialForm
    {
        // Diccionario para almacenar los títulos de los cursos y sus URLs
        private readonly Dictionary<string, string> videos = new Dictionary<string, string>
        {
            { "Video Formativo Escrituras", "https://www.youtube.com/watch?v=coNKcb5PiaU" },
            { "Video Formativo Polizas", "https://www.youtube.com/watch?v=9EiSGrf7wnQ" },
            { "Notaword - Preparación de escrituras", "https://www.youtube.com/watch?v=YMXKCKp17LU" },
            { "Notaword - Barra Notaword", "https://www.youtube.com/watch?v=FkDWKrJSTKU" },
            { "Notaword - Notasearch", "https://www.youtube.com/watch?v=DJmZbgtqGNI" },
            { "Notaword - Adjuntar documentación", "https://www.youtube.com/watch?v=jKvrFH1YWO0" },
            { "Notaword - Copias", "https://www.youtube.com/watch?v=UUCGDSHT1Rw" },
            { "Notaword - Pólizas", "https://www.youtube.com/watch?v=JoEmbXloxEk" }
        };

        // Lista de claves del diccionario para navegar
        private List<string> videoKeys;
        // Índice del video actual
        private int currentIndex = 0;

        public Aprendizaje()
        {
            InitializeComponent();
        }

        // Método que genera el HTML para incrustar el video de YouTube
        private string GenerateVideoHtml(string url)
        {
            return $@"
        <html>
            <head>
                <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css'>
                <style>
                    body {{
                        display: flex;
                        height: 100vh;
                        margin: 0;
                        overflow: hidden;
                        font-family: Arial, sans-serif;
                        position: relative;
                    }}
                    #sidebar {{
                        width: 250px;
                        background-color: #f8f9fa;
                        padding: 10px;
                        overflow-y: auto;
                        position: absolute;
                        top: 0;
                        left: 0;
                        bottom: 0;
                        transition: transform 0.3s ease;
                        z-index: 2;
                        padding-top: 65px;  /* Asegura que el contenido no se tape con el botón */
                    }}
                    #sidebar.hidden {{
                        transform: translateX(-100%);
                    }}
                    #videoContainer {{
                        flex: 1;
                        display: flex;
                        justify-content: center;
                        align-items: center;
                        padding: 10px;
                        height: 100%;
                        margin-left: 0;
                        transition: margin-left 0.3s ease;
                    }}
                    iframe {{
                        width: 100%;
                        height: 100%;
                        border: none;
                    }}
                    .video-item {{
                        padding: 10px;
                        cursor: pointer;
                        margin-bottom: 5px;
                        border-radius: 5px;
                        transition: background-color 0.3s;
                    }}
                    .video-item:hover {{
                        background-color: #007bff;
                        color: white;
                    }}
                    #toggleSidebarButton {{
                        position: fixed;
                        top: 10px;
                        left: 10px;
                        background-color: #007bff;
                        color: white;
                        border: none;
                        padding: 10px;
                        cursor: pointer;
                        border-radius: 5px;
                        font-size: 20px;
                        z-index: 3;
                    }}
                </style>
            </head>
            <body>
                <button id='toggleSidebarButton' onclick='toggleSidebar()'>☰</button>

                <div id='sidebar'>
                    <h3>Listado de Cursos</h3>
                    <ul class='list-unstyled'>
                        {string.Join("", videoKeys.Select(video => $"<li class='video-item' onclick='changeVideo(\"{videos[video]}\")'>{video}</li>"))}
                    </ul>
                </div>

                <div id='videoContainer'>
                    <iframe id='videoFrame' src='{url.Replace("watch?v=", "embed/")}' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>
                </div>

                <script>
                    function changeVideo(videoUrl) {{
                        document.getElementById('videoFrame').src = videoUrl.replace('watch?v=', 'embed/');
                    }}

                    function toggleSidebar() {{
                        var sidebar = document.getElementById('sidebar');
                        var videoContainer = document.getElementById('videoContainer');
                        sidebar.classList.toggle('hidden');
                        if (sidebar.classList.contains('hidden')) {{
                            videoContainer.style.marginLeft = '0';
                        }} else {{
                            videoContainer.style.marginLeft = '250px';
                        }}
                    }}

                    // Ocultar el sidebar automáticamente después de 1 segundo
                    window.onload = function() {{
                        setTimeout(function() {{
                            var sidebar = document.getElementById('sidebar');
                            sidebar.classList.add('hidden');
                        }}, 1000); // Tiempo en milisegundos (1000ms = 1 segundo)
                    }};
                </script>
            </body>
        </html>";
        }


        // Evento que se ejecuta cuando el formulario se carga
        private void Aprendizaje_Load(object sender, EventArgs e)
        {
            // Obtener las claves del diccionario y almacenarlas en una lista
            videoKeys = videos.Keys.ToList();

            // Cargar el primer video
            if (videoKeys.Count > 0)
            {
                currentIndex = 0;
                PlayVideo(currentIndex);
            }
        }

        // Método para reproducir un video
        private void PlayVideo(int index)
        {
            if (index >= 0 && index < videoKeys.Count)
            {
                string videoKey = videoKeys[index];
                string url = videos[videoKey];
                webBrowser1.DocumentText = GenerateVideoHtml(url);
            }
        }

        // Evento para abrir el video en YouTube directamente
        private void btnVerEnYouTube_Click(object sender, EventArgs e)
        {
            string videoSeleccionado = videoKeys[currentIndex]; // Obtenemos el video actualmente seleccionado
            if (!string.IsNullOrEmpty(videoSeleccionado) && videos.ContainsKey(videoSeleccionado))
            {
                string url = videos[videoSeleccionado];

                try
                {
                    System.Diagnostics.Process.Start("chrome.exe", url);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Process.Start(url);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un curso para ver.");
            }
        }

     

        // Evento para reproducir el siguiente video
        private void btnSiguienteVideo_Click(object sender, EventArgs e)
        {
            if (currentIndex < videoKeys.Count - 1)
            {
                currentIndex++;
                PlayVideo(currentIndex);
            }
            else
            {
                MessageBox.Show("Este es el último video.");
            }
        }

        // Evento para reproducir el video anterior
        private void btnVideoAnterior_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                PlayVideo(currentIndex);
            }
            else
            {
                MessageBox.Show("Este es el primer video.");
            }
        }
    }
}
