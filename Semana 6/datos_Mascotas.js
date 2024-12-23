//Dado un array de objetos que representan mascotas, filtra aquellas con más de cierta edad y muestra sus nombres después de un retraso.
function obtenerMascotasMayores(mascotas, edadMinima) {
    return new Promise((resolve) => {
        setTimeout(() => {
            const mayores = mascotas.filter(mascota => mascota.edad > edadMinima);
            const nombres = mayores.map(mascota => mascota.nombre);
            resolve(nombres);
        }, 3000); // Retraso simulado
    });
}

// Ejecutar con Async/Await
async function ejecutarEjercicio6() {
    const mascotas = [
        { nombre: "Bobby", tipo: "perro", edad: 5 },
        { nombre: "Michi", tipo: "gato", edad: 3 },
        { nombre: "Nala", tipo: "perro", edad: 7 },
    ];
    console.log("Obteniendo mascotas mayores a 4 años...");
    const nombres = await obtenerMascotasMayores(mascotas, 4);
    console.log("Mascotas mayores:", nombres);
}

ejecutarEjercicio6();



