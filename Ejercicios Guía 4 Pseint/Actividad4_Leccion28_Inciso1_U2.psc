Algoritmo Actividad4_Leccion28_Inciso1_U2
	Definir num, mult, acumulador, contador Como Entero
	acumulador = 0
	contador = 0
	mult = 0
	
	Para num = 1 Hasta 20 Con Paso 1 Hacer
		mult = num * 7
		acumulador = acumulador + mult
		
		Si (mult % 2 = 0) Entonces
			contador = contador + 1
		FinSi
	FinPara
	
	Escribir "La sumatoria de los primeros 20 múltiplos de 7 es: ",acumulador
	Escribir "Hay ", contador, " números pares entre los primeros múltiplos de 7"
FinAlgoritmo
