Algoritmo Actividad1_Leccion28_Inciso1_U2
	Definir strikes, dinero, total Como Entero
    strikes <- 0
    dinero <- 0
    total <- 0
    
    Repetir
        Escribir "Tienes ", strikes, " strike(s)"
        Escribir "Ingresa la cantidad de dinero ganada"
        Leer dinero
        
        Si dinero = 0 Entonces
            strikes <- strikes + 1
        SiNo
            total <- total + dinero
        FinSi
        
    Hasta Que strikes >= 3
    
    Escribir "Game Over"
    Escribir "Total acumulado: ", total
FinAlgoritmo
