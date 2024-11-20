using Microsoft.Office.Core;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Office = Microsoft.Office.Core;



namespace JPA.Ribbon_E3_xml
{
    [ComVisible(true)]
    public class Ribbon1 : Office.IRibbonExtensibility
    {
        private Office.IRibbonUI ribbon;
        private bool isOficialesVisible = false;
        private bool isCopiasVisible = false;
        private bool isHerramientasVisible = false;
        public Ribbon1()
        {
        }

        #region Miembros de IRibbonExtensibility

        public string GetCustomUI(string ribbonID)
        {
            return GetResourceText("JPA.Ribbon_E3_xml.Ribbon1.xml");
        }

        #endregion

        #region Devoluciones de llamada de la cinta de opciones
        //Cree métodos de devolución de llamada aquí. Para obtener más información sobre la adición de métodos de devolución de llamada, visite https://go.microsoft.com/fwlink/?LinkID=271226

        public void Ribbon_Load(Office.IRibbonUI ribbonUI)
        {
            this.ribbon = ribbonUI;
        }

        public System.Drawing.Image GetImage(string imageName)
        {
            var image = Properties.Resources.ResourceManager.GetObject(imageName) as System.Drawing.Image;
            if (image == null)
            {
                // Handle missing image, maybe log or return a default image
                throw new ArgumentException($"Image '{imageName}' not found.");
            }
            return image;
        }
        public void ShowHelpForm(IRibbonControl control)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }


        public void AprendizajeForm(IRibbonControl control)
        {

            Aprendizaje aprendizajeForm = new Aprendizaje();
            aprendizajeForm.ShowDialog();
        }

        // Alternar visibilidad de "Oficiales"
        public void ToggleOficialesVisibility(IRibbonControl control)
        {
            isOficialesVisible = !isOficialesVisible;
            isCopiasVisible = false;
            isHerramientasVisible = false;

            ribbon.InvalidateControl("grup_Oficiales");
            ribbon.InvalidateControl("grup_Copias");
            ribbon.InvalidateControl("grup_Herramientas");
        }

        // Alternar visibilidad de "Copias"
        public void ToggleCopiasVisibility(IRibbonControl control)
        {
            isOficialesVisible = false;
            isCopiasVisible = !isCopiasVisible;
            isHerramientasVisible = false;
            
            ribbon.InvalidateControl("grup_Oficiales");
            ribbon.InvalidateControl("grup_Copias");
            ribbon.InvalidateControl("grup_Herramientas");
        }

        // Alternar visibilidad de "Herramientas"
        public void ToggleHerramientasVisibility(IRibbonControl control)
        {
            isOficialesVisible = false;
            isCopiasVisible = false;
            isHerramientasVisible = !isHerramientasVisible;

            ribbon.InvalidateControl("grup_Oficiales");
            ribbon.InvalidateControl("grup_Copias");
            ribbon.InvalidateControl("grup_Herramientas");
        }

        // Funciones de visibilidad para cada grupo
        public bool GetOficialesVisibility(IRibbonControl control)
        {
            return isOficialesVisible;
        }

        public bool GetCopiasVisibility(IRibbonControl control)
        {
            return isCopiasVisible;
        }

        public bool GetHerramientasVisibility(IRibbonControl control)
        {
            return isHerramientasVisible;
        }

        public void OpenSupportLink(IRibbonControl control)
        {
            // The URL to open
            string url = "https://jpainformatica.info/soporte-tecnico";

            try
            {
                // Start Chrome with the URL
                System.Diagnostics.Process.Start("chrome.exe", url);
            }
            catch (Exception ex)
            {
                // If Chrome is not found, open in default browser
                System.Diagnostics.Process.Start(url);
            }
        }




        #endregion

        #region Asistentes

        private static string GetResourceText(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();
            for (int i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    using (StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
                    {
                        if (resourceReader != null)
                        {
                            return resourceReader.ReadToEnd();
                        }
                    }
                }
            }
            return null;
        }

        #endregion

    }



}
