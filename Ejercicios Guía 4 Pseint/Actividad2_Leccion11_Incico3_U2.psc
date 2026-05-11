Algoritmo Actividad2_Leccion11_Incico3_U2
	Definir num1, num2, i, mult Como Entero
	num1 = 0
	num2 = 0
	Escribir "Múltiplos de 4"
	
	Repetir
		Escribir ""
		Escribir "Dime el número 1: " Sin Saltar
		Leer num1
		Escribir "Dime el número 2: " Sin Saltar
		Leer num2
		Escribir ""
		
		Si (num1 > num2) Entonces
			Escribir "Múltiplos entre ",num2," y ",num1," : "
			Para i = num2 Hasta num1 Con Paso 1 Hacer
				mult = 4 * i;
				Escribir mult
			FinPara
		SiNo
			Escribir "Múltiplos entre ",num1," y ",num2," : "
			Para i = num1 Hasta num2 Con Paso 1 Hacer
				mult = 4 * i
				Escribir mult
			FinPara
		FinSi
			
	Hasta Que (num1 < 0)
FinAlgoritmo
