Algoritmo Actividad3_Leccion24_Inciso2_U2
	Definir num, i, acumulador Como Entero
	acumulador = 0;
	
	Escribir "Ingresa un número: "Sin Saltar
	Leer num
	
	Para i = num Hasta 1 Con Paso -1 Hacer
		Escribir i
		acumulador = acumulador + i;
	FinPara
	
	Escribir ""
	Escribir "La suma total de todos los números es de: ", acumulador
FinAlgoritmo
