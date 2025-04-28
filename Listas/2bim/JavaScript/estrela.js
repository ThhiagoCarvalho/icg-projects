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

function triangulo(x0, y0, x1, y1, x2, y2) {
    desenharReta(x0, y0, x1, y1);
    desenharReta(x1, y1, x2, y2);
    desenharReta(x2, y2, x0, y0);
}

function estrela(pontos, cor){
    for (let i = 0; i< 17; i+=2) desenharReta(pontos[i], pontos[i+1], pontos[i+2], pontos[i+3], cor);
    desenharReta(pontos[18], pontos[19], pontos[0], pontos[1], cor);
}

window.onload = function(){
    //estiloReta([10, 5], 1);
    
    let pontos = [
        250, 50,   // Ponto 1 (topo)
        300, 150,  // Ponto 2 (direita superior)
        450, 150,  // Ponto 3 (direita)
        325, 225,  // Ponto 4 (direita inferior)
        375, 375,  // Ponto 5 (baixo direito)
        250, 300,  // Ponto 6 (centro baixo)
        125, 375,  // Ponto 7 (baixo esquerdo)
        175, 225,  // Ponto 8 (esquerda inferior)
        50, 150,   // Ponto 9 (esquerda)
        200, 150   // Ponto 10 (esquerda superior)
    ];

    estrela(pontos, definirCor("rgb(255,0,0)"));
}