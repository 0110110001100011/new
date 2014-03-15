@Code
    ViewData("Title") = "Contacto"
End Code

<div class="contenedor_negro abajo_fixed">
    <hgroup class="title">
        <h1>@ViewData("Title").</h1>
        <h2>@ViewData("Message")</h2>
    </hgroup>

    <section class="contact">
        <header>
            <h3 class="hverde">Phone</h3>
        </header>
        <p>
            <span class="label">Main:</span>
            <span>425.555.0100</span>
        </p>
        <p>
            <span class="label">After Hours:</span>
            <span>425.555.0199</span>
        </p>
    </section>

    <section class="contact">
        <header>
            <h3 class="hverde">Email</h3>
        </header>
        <p>
            <span class="label">Support:</span>
            <span><a href="mailto:Support@example.com">Support@example.com</a></span>
        </p>
        <p>
            <span class="label">Marketing:</span>
            <span><a href="mailto:Marketing@example.com">Marketing@example.com</a></span>
        </p>
        <p>
            <span class="label">General:</span>
            <span><a href="mailto:General@example.com">General@example.com</a></span>
        </p>
    </section>

    <section class="contact">
        <header>
            <h3 class="hverde">Address</h3>
        </header>
        <p>
            One Microsoft Way<br />
            Redmond, WA 98052-6399
        </p>
    </section>
</div>