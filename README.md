# 🏥 SaludAr - Sistema de Gestión Clínica

SaludAr es una clínica médica que necesita un sistema para calcular y mostrar información sobre los servicios que ofrece, incluyendo la venta de medicamentos y servicios médicos.

## 📋 Descripción General

El sistema SaludAr permite gestionar la facturación de una clínica médica que ofrece venta de medicamentos y dos tipos de servicios médicos: Servicio de Internación y Servicio de Laboratorio. A continuación, se detallan las características y funcionalidades del sistema.

### 💊 Venta de Medicamentos

- Cada medicamento tiene los siguientes atributos:
  - Nombre del medicamento.
  - Porcentaje de ganancia.
  - Precio de lista.

- Para calcular el precio final de un medicamento, se siguen estos pasos:
  1. Se suma el porcentaje de ganancia al precio de lista.
  2. Se agrega el 21% de IVA.

### 🏨 Servicios Médicos

Los servicios médicos se dividen en dos tipos:

#### 🛏️ Servicio de Internación

- Se conoce la especialidad.
- Se registra la cantidad de días que el paciente estuvo internado.
- El precio se calcula multiplicando la cantidad de días por $20,000, que es el valor por día de internación.

#### 🧪 Servicio de Laboratorio

- Se registra el nombre del estudio.
- Se registra la cantidad de días desde que se tomó la muestra hasta obtener el resultado.
- Se asigna un nivel de complejidad, que va del 1 al 5.
- El precio se calcula multiplicando la cantidad de días por $10,000, que es el valor por día que lleva realizar el estudio.
- Si el nivel de complejidad es mayor a 3, se incrementa el precio en un 25%.

- Para ambos tipos de servicios, se suma la mitad del IVA sobre su precio. El IVA a tomar es del 21%.

### 🚀 Funcionalidades

El sistema proporciona las siguientes funcionalidades:

- Agregar un nuevo servicio (ya sea de internación o laboratorio) con la información requerida.
- Mostrar detalles de los servicios, incluyendo los medicamentos vendidos.
- Salir del programa.

Además, se implementaron dos métodos que se muestran al finalizar el programa:

- `montoTotalFacturado`: Devuelve el valor total facturado por la clínica, considerando tanto los medicamentos vendidos como los servicios prestados.
- `cantServiciosSimples`: Devuelve la cantidad de servicios de laboratorio con nivel de complejidad menor a 3.

Este sistema permite a SaludAr gestionar de manera efectiva sus servicios médicos y la venta de medicamentos, manteniendo un historial de facturación actualizado y proporcionando información financiera relevante.

## 💡 Instrucciones de Uso

El sistema se ejecuta por consola a través de una interfaz de línea de comandos, donde se podrán agregar servicios, mostrar detalles y obtener información financiera a través de los métodos mencionados anteriormente.

© 2023 SaludAr - Sistema de Gestión Clínica