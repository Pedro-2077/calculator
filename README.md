# 📟 Calculadora Simples em C#

Este projeto é uma calculadora de terminal escrita em **C#**, com um menu interativo e suporte às quatro operações básicas: **soma, subtração, multiplicação e divisão**.

---

## 🚀 Funcionalidades

- [x] Interface de texto simples no console  
- [x] Limpa a tela entre as operações  
- [x] Validação de divisão por zero  
- [x] Retorno automático ao menu após cada operação  
- [x] Encerramento amigável da aplicação  

---

## 🛠 Tecnologias Utilizadas

- Linguagem: **C# (.NET Core ou .NET 5/6)**
- Plataforma: **Console Application**
- IDE recomendada: [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/) com extensão C#

---

## ▶️ Como Executar

### 1. Clone o repositório

```bash
git clone https://github.com/Pedro-2077/calculator.git
```

### 2. Acesse o diretório

```bash
cd calculator
```

### 3. Compile e execute o programa

Se estiver usando o .NET CLI:

```bash
dotnet build
dotnet run
```

---

## 🧮 Exemplo de Uso

```
Calculadora Simples
1 - Soma
2 - Subtração
3 - Multiplicação
4 - Divisão
5 - Sair

Selecione uma operação:
```

> Após escolher uma opção, a aplicação solicitará os dois números e exibirá o resultado.

---

## 📌 Estrutura do Projeto

* `Program.cs`: Arquivo principal contendo toda a lógica da calculadora.
* Funções disponíveis:
  * `Menu()`: Exibe as opções e navega para a operação selecionada
  * `Soma()`, `Subtracao()`, `Multiplicacao()`, `Divisao()`: Realizam os cálculos

---

## ❗ Validações

* A divisão verifica se o divisor é zero antes de calcular
* O menu trata opções inválidas com mensagens amigáveis

---

## 📄 Licença

Este projeto está sob a licença **MIT**. Sinta-se livre para usar, modificar e distribuir.