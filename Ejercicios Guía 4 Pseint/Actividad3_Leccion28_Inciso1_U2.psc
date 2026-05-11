Algoritmo Actividad3_Leccion28_Inciso1_U2
	Definir contador, acumulador, num, i, divisores Como Entero
    contador = 0
    acumulador = 0
    
    Para num = 1 Hasta 100 Con Paso 1 Hacer
        divisores = 0
        
        Para i = 1 Hasta num Con Paso 1 Hacer
            Si num % i = 0 Entonces
                divisores <- divisores + 1
            FinSi
        FinPara
        
        Si divisores = 2 Entonces
            contador = contador + 1
            acumulador = acumulador + num
        FinSi
    FinPara
    
    Escribir "Cantidad total de números primos: ", contador
    Escribir "Suma total de todos los números primos: ", acumulador
FinAlgoritmo
