# Mini-Proyecto Ágil con Integración Continua

## Descripción

Este proyecto consiste en una calculadora básica desarrollada en C# que permite realizar operaciones de suma, resta, multiplicación y división. El objetivo principal fue aplicar prácticas de calidad dentro de un flujo de desarrollo ágil utilizando Git y GitHub.

## Prácticas de calidad aplicadas

### 1. Coding Standards

Se configuró un archivo `.editorconfig` para establecer reglas de formato y estilo del código, como el tipo de sangría, codificación, saltos de línea y organización del código.

Esta práctica ayuda a evitar inconsistencias de estilo entre desarrolladores y reduce el retrabajo durante la integración del código.

### 2. Pull Request y Code Review

El desarrollo de la calculadora se realizó en la rama `feature/calculadora`. Posteriormente se creó un Pull Request hacia la rama `master` y se realizó una revisión del código antes de integrarlo.

Esta práctica permite detectar errores antes de incorporar cambios a la versión principal y favorece la integración frecuente en lugar de realizar una integración tardía tipo “Big Bang”.

### 3. Integración Continua

Se configuró GitHub Actions para ejecutar automáticamente la restauración de dependencias, la verificación del formato del código y la compilación del proyecto cada vez que se realizan cambios en la rama principal.

Esto permite detectar problemas de integración de manera temprana y reducir el riesgo de acumular errores y retrabajo.

## Reflexión

La aplicación de estas prácticas demuestra que incluso en un proyecto pequeño es posible integrar calidad desde el inicio. Utilizar estándares de código, revisiones mediante Pull Request e Integración Continua permite detectar problemas rápidamente y mantener cambios pequeños y controlados. Esto se relaciona con los principios discutidos en clase, ya que evita realizar una integración completa al final del proyecto y disminuye el riesgo asociado a un enfoque “Big Bang”.

## Repositorio

https://github.com/oscarFune19/MiniProyectoAgil
