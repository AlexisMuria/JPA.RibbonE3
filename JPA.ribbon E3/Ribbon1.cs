using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Core;


namespace JPA.ribbon_E3
{
    
    public partial class NotaWord
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            // Estado inicial: ambos grupos colapsados
            SetCopiasGroupSize(expand: false);
            SetherramientasGroupSize(expand: false);
            SetOficialesGroupSize(expand: false);
        }

        // Método para expandir o colapsar el grupo de formato
        private void SetCopiasGroupSize(bool expand)
        {
            if (expand)
            {
                // Configuración para el estado expandido del grupo de formato
                grup_Copias.Visible = true;        // Mostrar grupo de formato
            }
            else
            {
                // Configuración para el estado contraído del grupo de formato
                grup_Copias.Visible = false;       // Ocultar grupo de formato
            }
            Btn_Copias.Visible = true;          // Mantener el botón visible siempre
        }

        // Método para expandir o colapsar el grupo herramientas
        private void SetherramientasGroupSize(bool expand)
        {
            if (expand)
            {
                // Configuración para el estado expandido del grupo herramientas
                grup_Herramientas.Visible = true;        // Mostrar grupo herramientas
               
            }
            else
            {
                // Configuración para el estado contraído del grupo herramientas
                grup_Herramientas.Visible = false;       // Ocultar grupo herramientas
            }
            Btn_Herramientas.Visible = true;      
        }

        private void SetOficialesGroupSize(bool expand)
        {
            if (expand)
            {
                // Configuración para el estado expandido del grupo Oficiales
                grup_Oficiales.Visible = true;        // Mostrar grupo Oficiales
            }
            else
            {
                // Configuración para el estado contraído del grupo Oficiales
                grup_Oficiales.Visible = false;       // Ocultar grupo Utils
            }
            Btn_Oficiales.Visible = true;        // Mantener el botón visible siempre
        }

        // Métodos para manejar los eventos de clic
        private void btnExpand_Click(object sender, RibbonControlEventArgs e)
        {
            // Alternar la visibilidad del grupo de formato
            bool isCurrentlyVisible = grup_Copias.Visible;
            SetCopiasGroupSize(expand: !isCurrentlyVisible);

            // Colapsar los otros grupos
            SetherramientasGroupSize(expand: false);
            SetOficialesGroupSize(expand: false);
        }

        private void btnHerramientasExpand_Click(object sender, RibbonControlEventArgs e)
        {
            // Alternar la visibilidad del grupo herramientas
            bool isCurrentlyVisible = grup_Herramientas.Visible;
            SetherramientasGroupSize(expand: !isCurrentlyVisible);

            // Colapsar los otros grupos
            SetCopiasGroupSize(expand: false);
            SetOficialesGroupSize(expand: false);

        }

        private void btnOficialesExpand_Click(object sender, RibbonControlEventArgs e)
        {
            // Alternar la visibilidad del grupo Oficiales
            bool isCurrentlyVisible = grup_Oficiales.Visible;
            SetOficialesGroupSize(expand: !isCurrentlyVisible);

            // Colapsar los otros grupos
            SetCopiasGroupSize(expand: false);
            SetherramientasGroupSize(expand: false);

        }

    }
}
