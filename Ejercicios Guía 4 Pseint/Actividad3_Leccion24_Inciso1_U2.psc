Algoritmo Actividad3_Leccion24_Inciso1_U2
	Definir i, j, suma, divisores  Como Entero
	suma = 0
	
	Para i = 1 Hasta 50 Con Paso 1 Hacer
		divisores = 0
		Para j = 1 Hasta i Con Paso 1 Hacer
			Si (i % j == 0) Entonces
				divisores = divisores + 1;
			FinSi
		FinPara
		Si (divisores == 2) Entonces
			suma = suma + i
		FinSi
	FinPara
	
	Escribir "La suma de todos los números primos del 1 hasta el 50 es de: ",suma
	
FinAlgoritmo
