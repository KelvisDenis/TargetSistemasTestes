# Testes para Vaga de Desenvolvedor

Este repositório contém os testes realizados para uma vaga de desenvolvedor. O projeto é dividido em diferentes pastas, cada uma com um propósito específico relacionado aos requisitos da vaga.

## Estrutura do Repositório

- **Data/**: Contém o arquivo `dados.json` e `dadosCidade.json` , utilizado nos testes relacionados ao faturamento e ao percentual nas cidades.
- **FaturamentoTesteWithC#/**: Teste para processar e analisar dados de faturamento diário a partir de um arquivo JSON.
- **FibonacciTesteWithC#/**: Teste para verificar se um número pertence à sequência de Fibonacci.
- **PercentualTesteWithC#/**: Teste para calcular o percentual de representação de valores em relação a um total.
- **StringInvert/**: Teste para inverter uma string sem utilizar funções prontas.
- **TesteTarget.sln**: Solução do Visual Studio que agrupa todos os projetos.
- **README.md**: Este arquivo de documentação.

---

## Testes Realizados

### 1. **Faturamento Diário**
**Objetivo:** Processar um arquivo JSON com dados de faturamento diário e:
- Identificar o menor e o maior valor de faturamento.
- Calcular a média de faturamento nos dias úteis (excluindo dias com faturamento igual a zero).
- Determinar quantos dias tiveram faturamento acima da média.

**Tecnologias Utilizadas:**
- C#
- Biblioteca Newtonsoft.Json para manipulação de JSON.

**Execução:**
1. Certifique-se de que o arquivo `dados.json` esteja no diretório `Data/`.
2. Execute o projeto `FaturamentoTesteWithC#` na solução `TesteTarget.sln`.

---

### 2. **Sequência de Fibonacci**
**Objetivo:** Implementar um programa que verifica se um número pertence à sequência de Fibonacci.

**Execução:**
1. Execute o projeto `FibonacciTesteWithC#` na solução `TesteTarget.sln`.
2. Insira um número quando solicitado para verificar se ele pertence à sequência.

---

### 3. **Percentual de Representação**
**Objetivo:** Calcular o percentual de representação de cada estado no total de um faturamento mensal.

**Execução:**
1. Execute o projeto `PercentualTesteWithC#` na solução `TesteTarget.sln`.
2. O resultado será exibido no console.

---

### 4. **Inversão de String**
**Objetivo:** Implementar um programa que inverte uma string sem usar funções prontas.

**Execução:**
1. Execute o projeto `StringInvert` na solução `TesteTarget.sln`.
2. Insira uma string quando solicitado e veja o resultado invertido no console.

---

## Requisitos para Execução

1. **.NET SDK:** Certifique-se de que o .NET SDK esteja instalado e configurado corretamente em sua máquina.
2. **Editor/IDE:** Recomenda-se o uso do Visual Studio ou Visual Studio Code para abrir e executar a solução.

## Como Clonar o Repositório

```bash
git clone <git@github.com:KelvisDenis/TargetSistemasTestes.git>
cd <TestesTarget>
```

Abra o arquivo `TesteTarget.sln` no Visual Studio para explorar e executar os testes.

---

## Contato
Para qualquer dúvida ou esclarecimento, entre em contato com [kelvisdenis@gmail.com].

