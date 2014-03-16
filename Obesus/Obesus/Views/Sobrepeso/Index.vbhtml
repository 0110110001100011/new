@Code
    Layout = "~/Views/Shared/_LayoutSobrepeso.vbhtml"
End Code
@Code
    ViewData("Title") = "Sobrepeso"
End Code

@section featured
    <section class="featured">
    <div id="intro" class="contenedor_negro obesidad float-left">
        <table>
            <tr>
                <th class="centrado"><h2 class="h_rojo">SOBREPESO</h2>
                <th>
            </tr>
            <tr>
                <td>
                    <h1 class="centrado">Que es la obesidad?</h1>
                    <p><br />
                        El sobrepeso y la obesidad se definen como una acumulación anormal o excesiva de grasa que
                        puede ser perjudicial para la salud.<br />
                        El sobrepeso y la obesidad son el quinto factor principal de riesgo de defunción en el mundo.<br />
                        Cada año fallecen por lo menos 2,8 millones de personas adultas como consecuencia del sobrepeso
                        o la obesidad. Además, el 44% de la carga de diabetes, el 23% de la carga de cardiopatías
                        isquémicas y entre el 7% y el 41% de la carga de algunos cánceres son atribuibles al sobrepeso
                        y la obesidad.
                    </p>
                </td>
            </tr>
            <tr>
                <td>
                    <p>
                        A continuación se presentan algunas estimaciones mundiales de la OMS correspondientes a 2008:<br /><br />
                        >>1400 millones de adultos de 20 y más años tenían sobrepeso.<br />
                        >>De esta cifra, más de 200 millones de hombres y cerca de 300 millones de mujeres eran obesos.<br />
                        >>En general, más de una de cada 10 personas de la población adulta mundial eran obesas.<br /><br />
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
