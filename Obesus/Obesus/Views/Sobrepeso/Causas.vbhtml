@Code
    Layout = "~/Views/Shared/_LayoutSobrepeso.vbhtml"
End Code
@Code
    ViewData("Title") = "Sobrepeso Causas"
End Code

@section featured
    <section class="featured">
        <div id="intro" class="contenedor_negro">
            <table>
                <tr>
                    <th class="centrado"><h2 class="h_rojo">CAUSAS DEL SOBREPESO</h2>
                    <th>
                </tr>
                <tr>
                    <td>
                        <p>
                            La causa fundamental del sobrepeso y la obesidad es un desequilibrio energético entre 
                            calorías consumidas y gastadas. En el mundo, se ha producido:<br /><br />

                            >>Un aumento en la ingesta de alimentos hipercalóricos que son ricos en grasa, sal y 
                            azúcares pero pobres en vitaminas, minerales y otros micronutrientes.<br />
                            >>Un descenso en la actividad física como resultado de la naturaleza cada vez más 
                            sedentaria de muchas formas de trabajo, de los nuevos modos de desplazamiento y de 
                            una creciente urbanización.<br />
                        </p>
                    </td>
                </tr>
                
            </table>
        </div>
        <aside class="contenedor_negro submenu">
            <h3 class="h_rojo">Categorias</h3>
            <ul>
                <li>@Html.ActionLink("Sobrepeso", "Index", "Sobrepeso")</li>
                <li>@Html.ActionLink("Causas", "Causas", "Sobrepeso")</li>
                <li>@Html.ActionLink("IMC", "Imc", "Sobrepeso")</li>
            </ul>
        </aside>
    </section>
End Section
