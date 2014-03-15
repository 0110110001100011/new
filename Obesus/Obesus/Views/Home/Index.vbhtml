@Code
    ViewData("Title") = "Inicio"
End Code

@section featured
    <section class="featured">
        <script type="text/javascript" src="../Scripts/jquery.js"></script>
        <script type="text/javascript" src="../Scripts/slideshow.js"></script>
        <link rel="stylesheet" type="text/css" href="../Content/Slideshow.css" />
        <div class="content-wrapper">
            <div id="slideshow" class="centrado">
                <div class="img" id="img-0" style="z-index:0;">
                    <img src="../Images/img01.jpg" width="700" height="250" alt="" />
                </div>
                <div class="img" id="img-1" style="z-index:10;">
                    <img src="../Images/img02.jpg" width="700" height="250" alt="" />
                </div>
                <div class="img" id="img-2" style="z-index:20;">
                    <img src="../Images/img03.jpg" width="700" height="250" alt="" />
                </div>
                <div class="img" id="img-3" style="z-index:30;">
                    <img src="../Images/img04.jpg" width="700" height="250" alt="" />
                </div>
                <div id="rapidlinks-btns">
                    <div class="rapidlink-selected" id="rapidlink-0">
                        <a href="javascript:userChangeRapidLink('0');">
                            <img height="10" src="../Images/blank.png" width="10" alt="" />
                        </a>
                    </div>
                    <div class="rapidlink" id="rapidlink-1">
                        <a href="javascript:userChangeRapidLink('1');">
                            <img height="10" src="../Images/blank.png" width="10" alt="" />
                        </a>
                    </div>
                    <div class="rapidlink" id="rapidlink-2">
                        <a href="javascript:userChangeRapidLink('2');">
                            <img height="10" src="../Images/blank.png" width="10" alt="" />
                        </a>
                    </div>
                    <div class="rapidlink" id="rapidlink-3">
                        <a href="javascript:userChangeRapidLink('3');">
                            <img height="10" src="../Images/blank.png" width="10" alt="" />
                        </a>
                    </div>
                </div>
            </div>
        </div>
        <div id="intro" class="contenedor_negro">
            <table>
                <tr>
                    <th class="centrado"><h2 class="hverde">BIENVENIDO</h2>
                    <th>
                </tr>
                <tr>
                    <td>
                        <p>Aqui encontraras recetas, ejercicios y tips para poder vencer la obesidad y la desnutricion</p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <h3>Registrese:</h3>
                        <ol class="round">
                            <li class="one">
                                <h5>Acceso a beneficios</h5>
                                Usted podra registrarse de manera gratuita para tener acceso a contenido exclusivo
                            </li>

                            <li class="two">
                                <h5>Contacte a su especialista en Nutricion</h5>
                                Usted podra estar en contacto con expertos en el area de nutricion. Podra programar
                                su proxima cita asi como ver el tratamiento que le hayan asignado y llevar un control
                                de este.
                            </li>

                            <li class="three">
                                <h5>Escriba sus dudas</h5>
                                Podra acceder a nuestro foro privado en el cual podra preguntar y responder cualquier
                                tipo de dudas de otros miembros.
                            </li>
                        </ol>

                    </td>
                </tr>
            </table>
        </div>
    </section>
End Section
