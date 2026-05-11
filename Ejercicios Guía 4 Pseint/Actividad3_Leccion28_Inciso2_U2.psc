Algoritmo Actividad3_Leccion28_Inciso2_U2
	Definir contador1, contador2, contador3, contador4, acumulador_total Como Entero
	contador1 = 0
	contador2 = 0
	contador3 = 0
	contador4 = 0
	acumulador_total = 0
	
	Escribir "Presiona cualquier tecla para saber la ganancia de hoy."
	Esperar Tecla
	Escribir "-------------------------------------------------------"
	
	Para i = 1 Hasta 100 Con Paso 1 Hacer
		contador1 = contador1 + 1
		contador4 = contador4 + 20
	FinPara
	
	Para i = 101 Hasta 500 Con Paso 1 Hacer
		contador2 = contador2 + 1
		contador4 = contador4 + 50
	FinPara
	
	Para i = 501 Hasta 1000 Con Paso 1 Hacer
		contador3 = contador3 + 1
		contador4 = contador4 + 100
	FinPara
	
	acumulador_total = acumulador_total + contador4
	
	Escribir "En total hay ", contador1, " billetes de Q.20.00"
	Escribir "En total hay ", contador2, " billetes de Q.50.00"
	Escribir "En total hay ", contador3, " billetes de Q.100.00"
	Escribir "La ganancia total fue de : Q.", contador4 ,".00"
FinAlgoritmo
