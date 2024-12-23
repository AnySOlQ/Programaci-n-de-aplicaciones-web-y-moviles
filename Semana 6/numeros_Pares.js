//Dado un array de números, filtra los números pares con un retraso de tiempo.
function filtrarNumerosPares(arr) {
    return new Promise((resolve) => {
        setTimeout(() => {
            const pares = arr.filter(num => num % 2 === 0);
            resolve(pares);
        }, 2000); // Simula un retraso
    });
}

// Ejecutar con Async/Await
async function ejecutarEjercicio1() {
    const numeros = [1, 2, 3, 4, 5, 6, 7, 8];
    console.log("Procesando el array de números...");
    const pares = await filtrarNumerosPares(numeros);
    console.log("Números pares:", pares);
}

ejecutarEjercicio1();
