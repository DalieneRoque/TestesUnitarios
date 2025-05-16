# 🧮 Projeto: Calculadora com Histórico e Testes Automatizados

Este projeto em C# implementa uma **calculadora simples com histórico de operações** e inclui uma **bateria de testes automatizados** utilizando o framework **xUnit** para garantir a confiabilidade dos métodos.

---

## 📁 Estrutura do Projeto

* **Namespace `Teste`**: Contém a classe `Calculadora` com as quatro operações básicas e histórico de resultados.
* **Namespace `NovoTeste`**: Contém a classe `UnitTest1` com testes automatizados para cada método da calculadora.

---

## ⚙️ Funcionalidades da Calculadora

* ✅ **Soma**, **Subtração**, **Multiplicação** e **Divisão**.
* ✅ Armazena as **3 últimas operações** no histórico com data.
* ✅ Histórico retornado em ordem decrescente (mais recente primeiro).

---

## 🧪 Testes Automatizados (xUnit)

A classe `UnitTest1` cobre os seguintes testes:

### ✔️ Operações Matemáticas

* `TesteSomar`: Garante que a soma funcione corretamente.
* `TesteSubtrair`: Testa a subtração com vários conjuntos de dados.
* `TesteMultiplicar`: Verifica os resultados da multiplicação.
* `TesteDividir`: Valida a divisão com resultado exato.

### ⚠️ Validação de Erros

* `TestarDivisaoPorZero`: Garante que o método lança uma exceção ao tentar dividir por zero.

### 📚 Histórico

* `TestarHistorico`: Verifica se o histórico armazena apenas os **3 últimos resultados**.

---

## 🧠 Exemplo de Uso da Classe `Calculadora`

```csharp
var calculadora = new Calculadora("15/05/2025");
int resultado = calculadora.somar(10, 5);
List<string> historico = calculadora.historico();
```

---

## 🔍 Exemplo de Teste Unitário com xUnit

```csharp
[Theory]
[InlineData(1, 2, 3)]
[InlineData(4, 5, 9)]
public void TesteSomar(int n1, int n2, int resultado)
{
    Calculadora calculadora = construirClasse();
    int resultadoCalculadora = calculadora.somar(n1, n2);
    Assert.Equal(resultado, resultadoCalculadora);
}
```

---

## 🛠️ Tecnologias Utilizadas

* 🧮 **C#**
* 🧪 **xUnit** (para testes)
* 📦 **.NET Console Application**

---


## 📄 Licença 

Projeto de uso educacional. Livre para estudo, testes e aprimoramentos.

---

