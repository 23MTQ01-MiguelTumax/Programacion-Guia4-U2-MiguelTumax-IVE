Algoritmo Actividad2_Leccion11_Incico1_U2
	Definir num, i, contador Como Entero
	num = 0
	Escribir "Dime un número del 1 al 10 y te diré su factorial."
	
	Repetir 
		Escribir "Número: " Sin Saltar
		Leer num
		
		Si (num >= 11) Entonces
			Escribir "ERROR, CANTIDAD NO ACEPTADA"
		SiNo
			mult = 1;
			Para i = 1 Hasta num Con Paso 1 Hacer
				mult = mult * i;
			FinPara
			Escribir mult
		FinSi
	Hasta Que (num >= 10)
	
FinAlgoritmo
