"use strict"
//Es un intermediario entre el navegador y el servidor
if (navigator.serviceWorker) {
	navigator.serviceWorker.register("sw.js")
}