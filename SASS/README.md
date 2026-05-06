# 📘 Aprendendo SASS

Projeto simples com objetivo de documentar e praticar conceitos essenciais de **SASS (SCSS)**, incluindo configuração com npm, organização de estilos e reutilização de código.

---

## 🚀 Setup do Projeto

Dentro da pasta do projeto, execute:

```bash
npm init
```

Inicia o projeto e cria o `package.json`.

```bash
npm install
```

Instala dependências existentes no projeto.

```bash
npm install --save-dev sass
```

Instala o SASS como dependência de desenvolvimento.

---

## 🧱 Build de CSS

Instale ferramentas para build e compatibilidade:

```bash
npm install postcss postcss-cli autoprefixer --save-dev
npm install npm-run-all --save-dev
```

---

---

## ⚙️ Scripts (package.json)

Configure scripts padrão para automatizar o build do CSS (conforme imagem no projeto).

---

## 🎨 Variáveis no SASS

Uso de `$` para declarar variáveis reutilizáveis.

---

## 🔁 Mixins e Includes

Evita repetição de código com mixin e include.

## 📱 Responsividade com Mixin

Responsividade aprimorada com mixin e include.

---

## 🧩 Placeholder e Extend

Reutilização de estilos em várias elementos.

---

## 🧬 Nesting (Aninhamento)

## O `&` reutiliza o nome da classe pai.

## 📁 Estrutura Básica

```
/css
  style.css
/SASS
  arquivos .scss
index.html
package.json
```

---

## 🎯 Objetivo

- Aprender SASS na prática
- Reduzir repetição de código
- Melhorar organização de estilos
- Criar base escalável para projetos
