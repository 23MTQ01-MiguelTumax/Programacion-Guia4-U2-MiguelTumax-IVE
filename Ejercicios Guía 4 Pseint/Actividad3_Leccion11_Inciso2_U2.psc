Algoritmo Actividad3_Leccion11_Inciso2_U2
	Definir num, acumulador Como Entero
	acumulador = 0
	Escribir "Dime números y los iré sumando hasta que presiones 9."
	
	Repetir
		Escribir "Número: " Sin Saltar
		Leer num
		
		Si (num <> 9) Entonces
			acumulador = acumulador + num
		FinSi
		
	Hasta Que (num = 9)
	
	Escribir ""
	Escribir "El total es: ", acumulador
	
FinAlgoritmo
