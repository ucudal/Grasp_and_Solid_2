//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public static void ImprimirReceta(Recipe recipe){

            StringBuilder recibo = new StringBuilder($"Receta de: {recipe.FinalProduct.Description}");

            foreach (Step step in recipe.Steps){
                recibo.AppendLine($"{step.Quantity} de {step.Input.Description} usando {step.Equipment.Description} durante {step.Time}");
            }
            ConsolePrinter.WriteLine(recibo.ToString().TrimEnd());

        }
    }
}