Algoritmo Actividad2_Leccion24_Inciso1_U2
	Definir num, i, mult Como Real
	Escribir "Primeros 20 múltiplos de 4 son..."
	Escribir "Dime un número y te dire sus primeros 20 múltiplos"
	Escribir "Número: " Sin Saltar
	Leer num
	Limpiar Pantalla
	
	Esperar 1 Segundos
	Para i = 1 Hasta 20 Con Paso 1 Hacer
		mult = num * i;
		Escribir mult
	FinPara
	
FinAlgoritmo
