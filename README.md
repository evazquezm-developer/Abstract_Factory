Ejemplo del patrón creacional Abstract Factory.

La idea es utilizar el patrón para crear una fabrica de botones, para mac, linux o windows.

Para fines prácticos, solo se muestra el uso del patrón Abstract Factory, y la lógica para dibujar 
los botones en un modo gráfico, no se incluye en éste ejemplo.

1.- Definir la interfase IButton con el método Paint.

2.- Definir la interfase IButtonFactory con el método CreateButton que devuelve un objeto tipo IButton.

3.- Implementar las interfases IButton.

4.- Implementar la interface IButtonFactory para mac, linux y windows.

5.- En la clase Program crear un método que acepte un objeto de tipo IButtonFactory, que se encargará
    de instanciarlo y llamar a su método Paint.

Creado en .Net Core 6.

Ejecutar:

$ dotnet run
