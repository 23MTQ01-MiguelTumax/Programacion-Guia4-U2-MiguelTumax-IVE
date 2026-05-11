Algoritmo Actividad3_Leccion23_Inciso2_U2
	Definir num Como Entero
	num = 1
	Escribir "¿Número primo o no?"
	
	Mientras (num > 0) Hacer
		contador = 0
		Escribir ""
		Escribir "Dime un número: "
		Leer num
		
		Si (num <= 1 ) Entonces 
			Escribir "Ingresa un número dentro del rango por favor"
		SiNo
			Para i <- 1 Hasta num Hacer
				Si num % i = 0 Entonces
					contador <- contador + 1
				FinSi
			FinPara
			
			Si contador = 2 Entonces
				Escribir "Es un número primo."
			Sino
				Escribir "No es un número primo."
			FinSi
		FinSi
		
	FinMientras
FinAlgoritmo
