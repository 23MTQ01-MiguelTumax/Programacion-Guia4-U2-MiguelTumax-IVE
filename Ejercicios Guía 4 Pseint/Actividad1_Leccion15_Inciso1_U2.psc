Algoritmo Actividad1_Leccion15_Inciso1_U2
	Definir tiempo, voletos1, voletos2, acumulador1, acumulador2, resultado1, resultado2 Como Entero
	acumulador1 = 0
	acumulador2 = 0
	Escribir "REGISTRO DE BOLETOS VENDIDOS Y DINERO RECAUDADO"
	Escribir "-----------------------------------------------"
	Escribir "Precio voleto de adulto: Q.15.00"
	Escribir "Precio voleto de niño: Q.10.00"
	Escribir "-----------------------------------------------"
	
	Repetir 
		Escribir "¿Cuántos voletos de adulto va a comprar?"
		Escribir "Voletos adulto: " Sin Saltar
		Leer voletos1
		
		Escribir "¿Cuántos voletos de niño va a comprar?"
		Escribir "Voletos niño: " Sin Saltar
		Leer voletos2
		Escribir "----------------------------------------"
		
		Si (voletos1 >= 1) Entonces
			resultado1 = voletos1 * 15
		FinSi
		Si (voletos2 >= 0) Entonces
			resultado2 = voletos2 * 10
		FinSi
		
		acumulador1 = acumulador1 + voletos1 + voletos2
		acumulador2 = acumulador2 + resultado1 + resultado2
		
		tiempo = Aleatorio(1,15)
	Hasta Que (tiempo >= 10)
	
	Escribir "El tiempo de la atracción a terminado, gracias por visitarnos"
	Escribir "Total de voletos: ", acumulador1
	Escribir "Total de dinero: Q.", acumulador2, ".00"
FinAlgoritmo
