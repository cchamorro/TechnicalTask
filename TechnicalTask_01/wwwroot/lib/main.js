require.config({
    paths: {
        "jquery": "jquery-3.6.0.min", // Ruta a jQuery
        "kendo": "kendo.all.min", // Ruta a Kendo UI
        "intro": "intro.min", // Ruta a IntroJS
        "app": "app" // Ruta a tu archivo de lógica de la aplicación
    },
    shim: {
        "kendo": {
            deps: ["jquery"], // Kendo UI depende de jQuery
            exports: "kendo"
        },
        "intro": {
            deps: ["jquery"], // IntroJS depende de jQuery
            exports: "introJs"
        }
    }
});