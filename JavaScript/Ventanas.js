let youtubeURL="https://youtube.com";
let ventana=window.open(youtubeURL);
print();
confirm("Estas seguro de que queres salir?");
document.write("Distancia borde izquierdo de la pantalla/borde izquierdo de la ventana " + window.screenLeft
	+ "<br> Distancia borde superior de la pantalla/borde superior de la ventana " + window.screenTop + "<br>");
document.write(window.location.href);