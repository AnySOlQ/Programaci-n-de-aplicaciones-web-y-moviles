function registrarFactura(factura, callback) {
    setTimeout(() => {
        console.log(`Factura #${factura.id} registrada con un total de $${factura.total}`);
        callback(factura);
    }, 1000);
}

const factura = { id: 123, total: 250.75 };
registrarFactura(factura, (factura) => {
    console.log(`Notificación enviada para la factura #${factura.id}`);
});
//Sirve para registrar una nueva factura en el sistema y que se notifique al usuario