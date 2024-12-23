//Dado un array de objetos con información de personas, calcula el promedio de sus edades después de un retraso.
function calcularPromedio(personas) {
    return new Promise((resolve) => {
        setTimeout(() => {
            const totalEdades = personas.reduce((suma, persona) => suma + persona.edad, 0);
            const promedio = totalEdades / personas.length;
            resolve(promedio);
        }, 2000); // Retraso simulado
    });
}

// Ejecutar con Async/Await
async function ejecutarEjercicio4() {
    const personas = [
        { nombre: "Carlos", edad: 40 },
        { nombre: "Lucía", edad: 25 },
        { nombre: "Pedro", edad: 30 },
    ];
    console.log("Calculando el promedio de edades...");
    const promedio = await calcularPromedio(personas);
    console.log("Promedio de edades:", promedio);
}

ejecutarEjercicio4();
