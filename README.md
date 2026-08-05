# FlowMarket DevSecOps Workshop  

Proyecto académico para el curso de DevSecOps y Observabilidad para Microservicios .NET.  

# Proyecto Base

Este proyecto sirve como punto de partida para nuevos desarrollos.

## 1. Clonar el repositorio

Ejecute el siguiente comando para clonar el proyecto:

```bash
git clone https://github.com/itafur2810/flowmarket-devsecops-workshop.git
```

Ingrese a la carpeta del proyecto:

```bash
cd flowmarket-devsecops-workshop
```

---

## 2. Verificar el repositorio remoto

Puede verificar el repositorio remoto configurado ejecutando:

```bash
git remote -v
```

Obtendrá un resultado similar a:

```text
origin  https://github.com/itafur2810/flowmarket-devsecops-workshop.git (fetch)
origin  https://github.com/itafur2810/flowmarket-devsecops-workshop.git (push)
```

---

## 3. Eliminar el repositorio remoto

Para evitar realizar cambios sobre el repositorio original, elimine el `origin`:

```bash
git remote remove origin
```

Verifique que fue eliminado:

```bash
git remote -v
```

Si no aparece ninguna salida, el repositorio remoto fue eliminado correctamente.

---

## 4. Crear un nuevo repositorio en GitHub

Cree un nuevo repositorio vacío en su cuenta de GitHub.

> **Importante:** No agregue README, `.gitignore` ni licencia al crear el repositorio, ya que el proyecto ya contiene estos archivos.

Por ejemplo:

```
https://github.com/mi-usuario/mi-proyecto.git
```

---

## 5. Agregar el nuevo repositorio remoto

Configure el nuevo repositorio como `origin`:

```bash
git remote add origin https://github.com/mi-usuario/mi-proyecto.git
```

Verifique la configuración:

```bash
git remote -v
```

Resultado esperado:

```text
origin  https://github.com/mi-usuario/mi-proyecto.git (fetch)
origin  https://github.com/mi-usuario/mi-proyecto.git (push)
```

---

## 6. Publicar el proyecto

Si el repositorio remoto está vacío, envíe la rama principal:

```bash
git push -u origin main
```

Si su rama principal se llama `master`, utilice:

```bash
git push -u origin master
```

---

## 7. Verificar la rama actual

Si no sabe cómo se llama su rama principal:

```bash
git branch
```

La rama actual aparecerá marcada con un asterisco (`*`).

Ejemplo:

```text
* main
```

---

## Comandos resumidos

```bash
git clone https://github.com/itafur2810/flowmarket-devsecops-workshop.git

cd flowmarket-devsecops-workshop

git remote remove origin

git remote add origin https://github.com/MI-USUARIO/MI-REPOSITORIO.git

git push -u origin main
```

---
