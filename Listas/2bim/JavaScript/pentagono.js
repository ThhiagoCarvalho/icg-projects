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

function pentagono(pontos, cor){
    for (let i = 0; i< 7; i+=2) desenharReta(pontos[i], pontos[i+1], pontos[i+2], pontos[i+3], cor);
    desenharReta(pontos[8], pontos[9], pontos[0], pontos[1], cor);
}

window.onload = function(){
    //estiloReta([10, 5], 1);

    let pontos = [
        100, 100,   // Ponto 1
        50, 150,    // Ponto 2
        50, 220,    // Ponto 3
        150, 220,   // Ponto 4
        150, 150    // Ponto 5
    ];    

    pentagono(pontos, definirCor("rgb(255,0,0)"));
}