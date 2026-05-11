Algoritmo Actividad3_Leccion15_Inciso2_U2
	Definir i, num, acumulador, divisores, contador Como Entero
	contador = 0
	acumulador = 0
	
	Para num = 300 Hasta 1 Con Paso -1 Hacer
		divisores = 0
		
		Si (num % 2 = 0) Entonces
			acumulador = acumulador + num
		FinSi
		
		Para i = 1 Hasta num Con Paso 1 Hacer
			Si (num % i = 0) Entonces
				divisores = divisores + 1
			FinSi
		FinPara
		
		Si (divisores = 2) Entonces
			contador = contador + 1
		FinSi
		
	FinPara
	
	Escribir "La suma de todos los pares es de: ", acumulador
	Escribir "Hay un total de ", contador, " números primos."
FinAlgoritmo
