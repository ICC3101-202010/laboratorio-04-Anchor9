¿Que diferencia podría generar no haber hecho las clases base abstractas?

Tener que escribir código mas repetitivo aun en cada una de las clases de maquinas, si bien es cierto no influye en una solución pequeña como un
laboratorio si en otros tipos de proyectos puede significar una gran dificultad a escribir y escribir lineas de código innecesario que 
llenan mas la memoria innecesariamente y conlleva al desorden (por muy específico que parezca escribir mas y mas lineas no siempre lo es)


¿Podría haber utilizado clases abstractas en vez de las interfaces? ¿Qué consecuencias tendría?

Claro, en este caso solo usé clases abstractas ya que existe un denominador común que es la máquina y que cumple con las 3 funciones que todas las
otras maquinas hacen, por ende usar clases abstractas me causa un mejor orden al momento de escribir codigo y no sobrellenar con informacion 




Explique cómo sabe .NET que complementación de un método heredado utilizar si se esta
refiriendo a una instancia de la clase hija a través de la clase padre.

Es porque va leyendo por niveles, partiendo del mas "general" hasta  el específico que quiere llegar, parte con la mas grande que puede contener la información como enunciado pero no especifica como actuar ni a quien, luego en las clases hijas se especifica que instancia se llama para así efectuar el método correspondiente.


