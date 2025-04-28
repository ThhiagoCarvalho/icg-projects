/*



*/


const canvas = document.getElementById("canvas");
const ctx = canvas.getContext("2d");
canvas.width = 800;
canvas.height = 800;

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

function aranha(pontos, cor){
    for (let i = 0; i< 157; i+=2) desenharReta(pontos[i], pontos[i+1], pontos[i+2], pontos[i+3], cor);
    desenharReta(pontos[158], pontos[159], pontos[0], pontos[1], cor);
}

window.onload = function(){
    //estiloReta([10, 5], 1);

    let pontos = [
        113, 66,
        100, 201,
        109, 334,
        165, 341,
        147, 321,
        143, 249,
        160, 133,
        202, 41,
        180, 210,
        187, 323,
        252, 325,
        228, 295,
        221, 251,
        227, 204,
        257, 171,
        287, 173,
        310, 209,
        316, 258,
        305, 296,
        283, 323,
        334, 330,
        353, 304,
        356, 211,
        350, 123,
        339, 40,
        382, 131,
        394, 234,
        390, 308,
        371, 337,
        424, 337,
        443, 260,
        435, 161,
        426, 64,
        459, 147,
        472, 234,
        475, 308,
        465, 368,
        402, 375,
        327, 368,
        404, 400,
        496, 447,
        487, 537,
        446, 652,
        399, 738,
        422, 649,
        442, 566,
        456, 477,
        408, 442,
        407, 522,
        384, 604,
        339, 706,
        362, 588,
        370, 467,
        337, 418,
        336, 518,
        319, 601,
        284, 664,
        265, 675,
        245, 666,
        210, 610,
        195, 542,
        196, 416,
        163, 442,
        159, 498,
        169, 589,
        189, 708,
        133, 566,
        119, 483,
        129, 440,
        74, 479,
        95, 610,
        126, 737,
        65, 597,
        42, 529,
        38, 439,
        113, 401,
        203, 368,
        73, 377,
        63, 267,
        75, 167
    ];
    

    aranha(pontos, definirCor("rgb(255,0,0)"));
}