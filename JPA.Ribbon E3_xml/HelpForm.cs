using Microsoft.Office.Core;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace JPA.Ribbon_E3_xml
{
    public partial class HelpForm : MaterialSkin.Controls.MaterialForm
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // HTML actualizado con Bootstrap y diseño de acordeón
            string htmlContent = @"
                <html>
                <head>
                    <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css'>
                    <style>
                        body { font-family: Arial, sans-serif; color: #333; line-height: 1.6; margin: 10px; }
                        .container { max-width: 800px; margin: 0 auto; }
                        h1 { color: #007bff; font-size: 26px; text-align: center; margin-bottom: 30px; }
                        .card-header { background-color: #f7f7f7; cursor: pointer; }
                        .card-body { color: #333; }
                        .question { color: #C0504D; font-weight: bold; }
                    </style>
                </head>
                <body>
                    <div class='container'>
                        <h1>FAQ - Preguntas Más Frecuentes NotaWord</h1>
                        <div id='accordion'>

                         
                            <div class='card'>
                                <div class='card-header' id='headingOne'>
                                    <h5 class='mb-0'>
                                        <button class='btn btn-link' data-toggle='collapse' data-target='#collapseOne' aria-expanded='true' aria-controls='collapseOne'>
                                            1.- BARRA DE NOTAWORD DESHABILITADA
                                        </button>
                                    </h5>
                                </div>
                                <div id='collapseOne' class='collapse' aria-labelledby='headingOne' data-parent='#accordion'>
                                    <div class='card-body'>
                                        <ul>
                                            <li><span class='question'>Pregunta:</span> ¿Por qué la barra de NotaWord está deshabilitada?</li>
                                            <li><span class='solution'>Posible solución:</span> Asegúrate de que NotaWord esté correctamente instalado y actualizado.</li>
                                            <li><span class='solution'>Posible solución:</span> Asegúrate de que el servidor esté encendido y se tenga acceso a la unidad de red.
                                                <a href='https://youtu.be/0FEqu8Tt5oI'>VÍDEO AQUÍ</a></li>
                                            <li><span class='solution'>Posible solución:</span> Si se ha producido un cambio de equipo, asegúrate que tu técnico ha contactado con JPA para configurar nuestros programas.</li>
                                            <li><span class='solution'>Verifica también la configuración de tu aplicación para habilitar la barra de NotaWord.
                                                <a href='https://youtu.be/eE_vBDgjF_8'>VÍDEO AQUÍ</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>

                            <div class='card'>
                                <div class='card-header' id='headingTwo'>
                                    <h5 class='mb-0'>
                                        <button class='btn btn-link collapsed' data-toggle='collapse' data-target='#collapseTwo' aria-expanded='false' aria-controls='collapseTwo'>
                                            2.- ICONOS DE NOTAWORD NO APARECEN
                                        </button>
                                    </h5>
                                </div>
                                <div id='collapseTwo' class='collapse' aria-labelledby='headingTwo' data-parent='#accordion'>
                                    <div class='card-body'>
                                        <ul>
                                            <li><span class='question'>Pregunta:</span> ¿Qué debo hacer si los iconos de NotaWord no aparecen?</li>
                                            <li><span class='solution'>Posible solución:</span> Asegúrate de que NotaWord esté correctamente instalado y actualizado.</li>
                                            <li><span class='solution'>Posible solución:</span> Asegúrate de que el servidor esté encendido y tengas acceso a la unidad de red.
                                                <a href='https://youtu.be/QWDsi-8OGqs'>VÍDEO AQUÍ</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                          
                            <div class='card'>
                                <div class='card-header' id='headingTree'>
                                    <h5 class='mb-0'>
                                        <button class='btn btn-link collapsed' data-toggle='collapse' data-target='#collapseTree' aria-expanded='false' aria-controls='collapseTree'>
                                            3.- PESTAÑA PE DESHABILITADA
                                        </button>
                                    </h5>
                                </div>
                                <div id='collapseTree' class='collapse' aria-labelledby='headingTree' data-parent='#accordion'>
                                    <div class='card-body'>
                                        <ul>
                                            <li><span class='question'>Pregunta:</span> ¿Por qué la pestaña de PE está deshabilitada?</li>
                                            <li><span class='solution'>Posible solución:</span> Asegúrate de que NotaWord está correctamente instalado y actualizado.</li>
                                            <li><span class='solution'>Verifica también la configuración de tu aplicación para habilitar la barra de NotaWord.
                                                <a href='https://youtu.be/1WW4hCTNGiw'>VÍDEO AQUÍ</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                      
                            <div class='card'>
                                <div class='card-header' id='headingfour'>
                                    <h5 class='mb-0'>
                                        <button class='btn btn-link collapsed' data-toggle='collapse' data-target='#collapsefour' aria-expanded='false' aria-controls='collapsefour'>
                                            4.- IMPRESORA Y BANDEJA POR DEFECTO
                                        </button>
                                    </h5>
                                </div>
                                <div id='collapsefour' class='collapse' aria-labelledby='headingfour' data-parent='#accordion'>
                                    <div class='card-body'>
                                        <ul>
                                            <li><span class='question'>Pregunta:</span> ¿Cómo configurar mi impresora y bandejas predeterminadas en NotaWord?</li>
                                            <li><span class='solution'>Posible solución:</span> En un nuevo documento en NotaWord, presiona las teclas CTRL-I y luego CTRL-A.
                                                <a href='https://youtu.be/OpgZX7MlLw8'>VÍDEO AQUÍ</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>

                            <div class='card'>
                                <div class='card-header' id='headingfive'>
                                    <h5 class='mb-0'>
                                        <button class='btn btn-link collapsed' data-toggle='collapse' data-target='#collapsefive' aria-expanded='false' aria-controls='collapsefive'>
                                           5.- PE. ICONO DILIGENCIA EN ROJO Y ESTÁ FIRMADA
                                        </button>
                                    </h5>
                                </div>
                                <div id='collapsefive' class='collapse' aria-labelledby='headingfive' data-parent='#accordion'>
                                    <div class='card-body'>
                                        <ul>
                                            <li><span class='question'>Pregunta:</span> ¿Qué debo hacer si el icono de la diligencia está en rojo y está firmada en signo?</li>
                                            <li><span class='solution'>Posible solución:</span> Asegúrate de que has pulsado el icono “SINCRONIZAR CON SIGNO”.</li>
                                            <li><span class='solution'>Posible solución:</span> Asegúrate de que has creado el expediente en e3 o introducido los datos básicos en e2.
                                                <a href='https://youtu.be/TBt0Ffr0iWQ'>VÍDEO AQUÍ</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>

                            <div class='card'>
                                <div class='card-header' id='headingSix'>
                                    <h5 class='mb-0'>
                                        <button class='btn btn-link collapsed' data-toggle='collapse' data-target='#collapseSix' aria-expanded='false' aria-controls='collapseSix'>
                                            6.- PE. NO SE PUEDEN AGREGAR DILIGENCIAS Y/O NOTAS
                                        </button>
                                    </h5>
                                </div>
                                <div id='collapseSix' class='collapse' aria-labelledby='headingSix' data-parent='#accordion'>
                                    <div class='card-body'>
                                        <ul>
                                            <li><span class='question'>Pregunta:</span>  ¿Por qué no puedo agregar diligencias y notas?</li>
                                            <li><span class='solution'>Posible solución:</span> Asegúrate de que estás trabajando con documentos en formato compatible a docx.
                                                <a href='https://youtu.be/1_mGvAyaDLE'>VÍDEO AQUÍ</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                    <script src='https://code.jquery.com/jquery-3.5.1.slim.min.js'></script>
                    <script src='https://cdn.jsdelivr.net/npm/bootstrap@4.5.2/dist/js/bootstrap.bundle.min.js'></script>
                </body>
                </html>";

            // Establece el contenido HTML en el WebBrowser
            webBrowser1.DocumentText = htmlContent;

        }
        private void contacto_Load(object sender, EventArgs e)
        {
            // Contenido HTML con diseño Bootstrap mejorado para el contacto
            string htmlContent = @"
                <html>
                <head>
                    <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css'>
                    <style>
                        body { font-family: Arial, sans-serif; color: #333; margin: 20px; }
                        .container { max-width: 800px; margin: 0 auto; padding-top: 20px; }
                        h1 { color: #007bff; font-size: 26px; text-align: center; margin-bottom: 30px; }
                        .card-header { background-color: #f8f9fa; cursor: pointer; }
                        .contact-section { margin-top: 20px; }
                        .contact-card { margin-bottom: 20px; text-align: center; border: 1px solid #ddd; border-radius: 8px; padding: 15px; }
                        .contact-card img { margin-bottom: 15px; }
                        .contact-card h4 { color: #343a40; font-weight: bold; }
                        .contact-card p { margin: 0; color: #666; }
                        .btn-email { margin-top: 10px; }
                    </style>
                </head>
                <body>
                    <div class='container'>
                        <h1>Solicitar una Demostración o Más Información</h1>
                
                        <!-- Formulario de Contacto -->
                        <div class='card mb-4'>
                            <div class='card-header'>Formulario de Contacto</div>
                            <div class='card-body'>
                                <form>
                                    <div class='form-group'>
                                        <label for='email'>Correo Electrónico</label>
                                        <input type='email' class='form-control' id='email' placeholder='hola@ejemplo.com' required>
                                    </div>
                                    <div class='form-group'>
                                        <label for='message'>Solicitar Información de JPA</label>
                                        <textarea class='form-control' id='message' rows='3' required></textarea>
                                    </div>
                                    <div class='form-check'>
                                        <input type='checkbox' class='form-check-input' id='terms' required>
                                        <label class='form-check-label' for='terms'>Acepto la <a href='https://jpainformatica.info/politica-de-privacidad' target='_blank'>política de privacidad</a></label>
                                    </div>
                                    <button type='submit' class='btn btn-primary btn-block mt-3'>Enviar</button>
                                </form>
                            </div>
                        </div>

                        <!-- Sección de Contacto -->
                        <div class='contact-section'>
                            <div class='row'>
                        
                                <!-- Sede Central -->
                                <div class='col-md-4 contact-card'>
                                    <img src='https://basekit-product.s3-eu-west-1.amazonaws.com/icons/icon-1.svg' alt='Sede Central' width='60'>
                                    <h4>Sede Central</h4>
                                    <p>Calle Juan de Herrera, 5<br>(03203) Elche, Alicante</p>
                                    <p>Tel: 96 665 10 56</p>
                                    <a href='mailto:info@jpasl.com' class='btn btn-outline-primary btn-email'>Email Contacto</a>
                                </div>

                                <!-- Delegación Barcelona -->
                                <div class='col-md-4 contact-card'>
                                    <img src='https://basekit-product.s3-eu-west-1.amazonaws.com/icons/icon-2.svg' alt='Delegación Barcelona' width='60'>
                                    <h4>Delegación Barcelona</h4>
                                    <p>Ronda Universidad, 12<br>Planta 3, Despacho 5<br>(08007) Barcelona</p>
                                    <p>Tel: 93260 22 11</p>
                                    <a href='mailto:info@jpasl.com' class='btn btn-outline-primary btn-email'>Email Contacto</a>
                                </div>

                                <!-- Delegación Sevilla -->
                                <div class='col-md-4 contact-card'>
                                    <img src='https://basekit-product.s3-eu-west-1.amazonaws.com/icons/icon-3.svg' alt='Delegación Sevilla' width='60'>
                                    <h4>Delegación Sevilla</h4>
                                    <p>Duquesa de Alba, 40<br>(41807) Espartinas, Sevilla</p>
                                    <p>Tel: 647 73 42 65</p>
                                    <a href='mailto:antoniolopez@jpainformatica.es' class='btn btn-outline-primary btn-email'>Email Contacto</a>
                                </div>

                            </div>
                        </div>
                    </div>
            
                    <!-- JavaScript para Bootstrap -->
                    <script src='https://code.jquery.com/jquery-3.5.1.slim.min.js'></script>
                    <script src='https://cdn.jsdelivr.net/npm/bootstrap@4.5.2/dist/js/bootstrap.bundle.min.js'></script>
                </body>
                </html>";

            // Establece el contenido HTML en el WebBrowser
            webBrowser2.DocumentText = htmlContent;
        }



        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Itera sobre los enlaces y configura el evento de clic
            foreach (HtmlElement link in webBrowser1.Document.Links)
            {
                link.Click += new HtmlElementEventHandler(Link_Click);
            }
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Itera sobre los enlaces y configura el evento de clic
            foreach (HtmlElement link in webBrowser2.Document.Links)
            {
                link.Click += new HtmlElementEventHandler(Link_Click);
            }
        }


        private void Link_Click(object sender, HtmlElementEventArgs e)
        {
            // Obtiene la URL del enlace
            HtmlElement link = (HtmlElement)sender;
            string url = link.GetAttribute("href");

            try
            {
                // Verifica si el enlace es un "mailto"
                if (url.StartsWith("mailto:", StringComparison.OrdinalIgnoreCase))
                {
                    // Abre el enlace mailto en la aplicación de correo predeterminada
                    Process.Start(url);
                }
                else
                {
                    // Si no es un "mailto", abre en Google Chrome
                    Process.Start("chrome.exe", url);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el enlace: " + ex.Message);
            }

            e.ReturnValue = false; // Evita la navegación predeterminada en el WebBrowser
        }

    }
}
