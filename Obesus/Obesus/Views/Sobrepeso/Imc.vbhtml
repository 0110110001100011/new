@Code
    Layout = "~/Views/Shared/_LayoutSobrepeso.vbhtml"
End Code
@Code
    ViewData("Title") = "Sobrepeso IMC"
End Code

@section featured
    <section class="featured">
        <div id="intro" class="contenedor_negro obesidad float-left">
            <table>
                <tr>
                    <th class="centrado"><h2 class="h_rojo">IMC</h2>
                    <th>
                </tr>
                <tr>
                    <td>
                        <p>
                            El índice de masa corporal (IMC) es un indicador simple de la relación entre el peso y la talla
                            que se utiliza frecuentemente para identificar el sobrepeso y la obesidad en los adultos. Se
                            calcula dividiendo el peso de una persona en kilos por el cuadrado de su talla en metros (kg/m2).<br />
                        </p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <p>
                            La definición de la OMS es la siguiente:<br /><br />
                            Un IMC igual o superior a 25 determina sobrepeso.<br />
                            Un IMC igual o superior a 30 determina obesidad.<br /><br />
                            El IMC proporciona la medida más útil del sobrepeso y la obesidad en la población, puesto que es
                            la misma para ambos sexos y para los adultos de todas las edades.<br />
                        </p>

                    </td>
                </tr>
            </table>
        </div>

        <aside class="submenu float-right">
            <h2>Categorias</h2>
            <ul id="lista_submenu">
                <li>@Html.ActionLink("Sobrepeso", "Index", "Sobrepeso")</li>
                <li>@Html.ActionLink("Causas", "Causas", "Sobrepeso")</li>
                <li>@Html.ActionLink("IMC", "Imc", "Sobrepeso")</li>
            </ul>
        </aside>
    </section>
End Section
