const canvas = document.getElementById("canvas");
const ctx = canvas.getContext("2d");
canvas.width = 800;
canvas.height = 600;

function definirCor(texto_cor){
    return cor = texto_cor;
}

function desenharReta(x1, y1, x2, y2, cor){
    ctx.beginPath();
    ctx.strokeStyle = cor;
    ctx.moveTo(x1, y1);
    ctx.lineTo(x2, y2);
    ctx.stroke();
}

function estiloReta(estilo, espessura){
    ctx.setLineDash(estilo);
    ctx.lineWidth = espessura;
}

function retangulo(x0, y0, x1, y1, cor) {
    desenharReta(x0, y0, x1, y0, cor);
    desenharReta(x1, y0, x1, y1, cor);
    desenharReta(x1, y1, x0, y1, cor);
    desenharReta(x0, y1, x0, y0, cor);
}

window.onload = function(){
    //estiloReta([10, 5], 1);
    retangulo(100, 100, 400, 200, definirCor("rgb(255,0,0)"));
}