function generarResumen(facturas) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            if (facturas.length === 0) {
                reject("No hay facturas disponibles.");
            } else {
                const totalFacturado = facturas.reduce((sum, factura) => sum + factura.total, 0);
                resolve(`Resumen generado: ${facturas.length} facturas, Total facturado: $${totalFacturado}`);
            }
        }, 1500);
    });
}

const facturas = [
    { id: 101, total: 150.0 },
    { id: 102, total: 200.5 },
    { id: 103, total: 320.75 }
];

generarResumen(facturas)
    .then((resumen) => console.log(resumen))
    .catch((error) => console.error(error));
//La promesa permite hacer un resumen de las facturas y total facturado y lanza error si no hay facturas
