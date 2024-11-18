async function obtenerDetalleFactura(id) {
    try {
        const detalle = await new Promise((resolve, reject) => {
            setTimeout(() => {
                const factura = { id, total: 500.0, cliente: "Juan Pérez" };
                if (factura) resolve(factura);
                else reject(`Factura con ID ${id} no encontrada`);
            }, 1200);
        });

        console.log(`Factura encontrada: ID ${detalle.id}, Cliente: ${detalle.cliente}, Total: $${detalle.total}`);
    } catch (error) {
        console.error("Error:", error);
    }
}

obtenerDetalleFactura(201);
//Permite buscar un detalle específico en la factura y de no existir información, lanza error