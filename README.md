# ZDZCode.Payments.Asaas

![Logo](logo.png)

[![Build Status](https://dev.azure.com/zdzcode/ZDZCode.Payments.Asaas/_apis/build/status/ZDZCode.Payments.Asaas?branchName=main)](https://dev.azure.com/zdzcode/ZDZCode.Payments.Asaas/_build/latest?definitionId=1&branchName=main)
[![NuGet](https://img.shields.io/nuget/v/ZDZCode.Payments.Asaas.svg)](https://www.nuget.org/packages/ZDZCode.Payments.Asaas/)
[![License](https://img.shields.io/github/license/zdzcode-projects/ZDZCode.Payments.Asaas)](license.md)

Biblioteca .NET para integração com a API do [Asaas](https://www.asaas.com), plataforma brasileira de pagamentos e gestão financeira. Esta biblioteca fornece uma interface moderna, fortemente tipada e assíncrona para todos os recursos da API Asaas v3.

## 📋 Índice

- [Características](#-características)
- [Requisitos](#-requisitos)
- [Instalação](#-instalação)
- [Configuração](#-configuração)
- [Uso Básico](#-uso-básico)
- [Módulos Disponíveis](#-módulos-disponíveis)
- [Exemplos](#-exemplos)
- [Documentação](#-documentação)
- [Testes](#-testes)
- [Contribuindo](#-contribuindo)
- [Licença](#-licença)

## ✨ Características

- ✅ **Fortemente Tipada**: Todos os requests e responses são fortemente tipados
- ✅ **Assíncrona**: Todas as operações são assíncronas usando async/await
- ✅ **Documentação XML**: Todos os métodos incluem documentação XML completa em português
- ✅ **Suporte a Múltiplos Módulos**: Cobertura completa da API Asaas v3
- ✅ **.NET 8.0**: Suporta a versão mais recente do .NET
- ✅ **Ambiente Sandbox**: Suporte completo para ambiente de testes
- ✅ **Serialização Automática**: Conversão automática de JSON usando Newtonsoft.Json
- ✅ **Paginação**: Suporte nativo para listagens paginadas
- ✅ **Tratamento de Erros**: Tratamento robusto de erros HTTP

## 📦 Requisitos

- **.NET 8.0** ou superior
- Conta no [Asaas](https://www.asaas.com) (Sandbox ou Produção)
- Chave de API (access_token)

## 🚀 Instalação

### Via NuGet Package Manager

```bash
Install-Package ZDZCode.Payments.Asaas
```

### Via .NET CLI

```bash
dotnet add package ZDZCode.Payments.Asaas
```

### Via PackageReference

```xml
<PackageReference Include="ZDZCode.Payments.Asaas" Version="8.0.0" />
```

## ⚙️ Configuração

### 1. Configurar Variáveis de Ambiente

A biblioteca requer duas variáveis de ambiente:

```bash
# Token de API do Asaas
export ASAAS_TOKEN="seu_token_aqui"

# Ambiente (Production ou Development/Sandbox)
export ASPNETCORE_ENVIRONMENT="Development"  # Usa Sandbox
# ou
export ASPNETCORE_ENVIRONMENT="Production"   # Usa Produção
```

### 2. Registro no Container de Injeção de Dependência

```csharp
using ZDZCode.Payments.Asaas;
using Microsoft.Extensions.DependencyInjection;

// Em Program.cs ou Startup.cs
services.AddScoped<AsaasService>();
```

### 3. URLs da API

A biblioteca configura automaticamente a URL base conforme o ambiente:

- **Sandbox (Development)**: `https://sandbox.asaas.com/api/v3`
- **Production**: `https://api.asaas.com/v3`

## 💡 Uso Básico

### Exemplo Simples

```csharp
using ZDZCode.Payments.Asaas;
using ZDZCode.Payments.Asaas.DTO.Customer.Request;

// Injetar o serviço
public class PaymentService
{
    private readonly AsaasService _asaasService;

    public PaymentService(AsaasService asaasService)
    {
        _asaasService = asaasService;
    }

    public async Task CreateCustomerExample()
    {
        var request = new CustomerRequest
        {
            Name = "João Silva",
            CpfCnpj = "12345678901",
            Email = "joao@example.com",
            Phone = "1199999999",
            MobilePhone = "11988888888",
            Address = "Rua Exemplo",
            AddressNumber = "100",
            Province = "Centro",
            PostalCode = "01310-000"
        };

        var customer = await _asaasService.CreateNewCustomer(request);
        Console.WriteLine($"Cliente criado com ID: {customer.Id}");
    }
}
```

## 📚 Módulos Disponíveis

A biblioteca está organizada em módulos que correspondem aos recursos da API Asaas:

### Gestão de Clientes
- **Customer** (7 métodos): Criar, listar, recuperar, atualizar, remover e restaurar clientes

### Pagamentos e Cobranças
- **Payment** (11 métodos): Criar e gerenciar cobranças individuais
- **PaymentLink** (11 métodos): Criar e gerenciar links de pagamento
- **PaymentRefund** (3 métodos): Estornar pagamentos
- **PaymentSplit** (1 método): Divisão de pagamentos
- **PaymentDunning** (9 métodos): Negativação de inadimplentes
- **PaymentDocument** (1 método): Documentos de pagamento
- **PaymentWithSummaryData**: Pagamentos com dados resumidos

### Assinaturas e Recorrência
- **Subscription** (11 métodos): Criar e gerenciar assinaturas recorrentes
- **Installment** (8 métodos): Parcelamentos

### PIX
- **Pix** (7 métodos): Gerenciar chaves PIX e QR codes
- **PixTransaction** (3 métodos): Transações PIX

### Transferências e Financeiro
- **Transfer** (3 métodos): Transferências bancárias
- **Finance** (4 métodos): Informações financeiras
- **FinancialTransaction** (2 métodos): Transações financeiras
- **Anticipation** (4 métodos): Antecipações de recebíveis

### Notas Fiscais
- **Invoice** (7 métodos): Emissão e gestão de notas fiscais
- **FiscalInfo** (2 métodos): Informações fiscais

### Conta e Documentos
- **Accountinfo** (12 métodos): Informações da conta
- **AccountDocument** (3 métodos): Documentos da conta

### Outros Recursos
- **Notification** (3 métodos): Configuração de notificações
- **Webhook** (8 métodos): Gerenciar webhooks
- **CreditCard** (1 método): Tokenização de cartões
- **CreditBureauReport** (3 métodos): Consultas ao Serasa
- **Bill** (5 métodos): Pagamento de contas
- **MobilePhoneRecharge** (3 métodos): Recarga de celular
- **Subaccount** (3 métodos): Gestão de subcontas

## 📖 Exemplos

### Criar um Cliente

```csharp
var customerRequest = new CustomerRequest
{
    Name = "Maria Santos",
    CpfCnpj = "98765432100",
    Email = "maria@example.com",
    Phone = "1133334444",
    MobilePhone = "11977776666",
    Address = "Av. Paulista",
    AddressNumber = "1000",
    Complement = "Apto 101",
    Province = "Bela Vista",
    PostalCode = "01310-100"
};

var customer = await _asaasService.CreateNewCustomer(customerRequest);
```

### Criar uma Cobrança

```csharp
var paymentRequest = new CreateNewPaymentRequest
{
    Customer = "cus_000005119071", // ID do cliente
    BillingType = "BOLETO",
    Value = 100.00m,
    DueDate = DateTime.Now.AddDays(7),
    Description = "Pagamento de serviços",
    ExternalReference = "REF-001"
};

var payment = await _asaasService.CreateNewPayment(paymentRequest);
```

### Listar Cobranças com Filtros

```csharp
var request = new BaseAsaasRequest
{
    Offset = 0,
    Limit = 10,
    // Adicionar filtros conforme necessário
};

var payments = await _asaasService.GetListPayments(request);

foreach (var payment in payments.Data)
{
    Console.WriteLine($"Cobrança {payment.Id}: {payment.Value:C}");
}
```

### Criar uma Assinatura Recorrente

```csharp
var subscriptionRequest = new SubscriptionRequest
{
    Customer = "cus_000005119071",
    BillingType = "CREDIT_CARD",
    Value = 49.90m,
    NextDueDate = DateTime.Now.AddMonths(1),
    Cycle = "MONTHLY",
    Description = "Assinatura Mensal - Plano Premium"
};

var subscription = await _asaasService.CreateSubscription(subscriptionRequest);
```

### Criar um Webhook

```csharp
var webhookRequest = new WebhookRequest
{
    Name = "Webhook de Pagamentos",
    Url = "https://seu-site.com/webhook/asaas",
    Email = "notificacoes@seu-site.com",
    Enabled = true,
    Interrupted = false,
    AuthToken = "seu-token-secreto"
};

var webhook = await _asaasService.CreateWebhook(webhookRequest);
```

### Recuperar Informações da Conta

```csharp
var accountInfo = await _asaasService.GetRetrieveAccountInfo();
Console.WriteLine($"Saldo: {accountInfo.Balance:C}");
```

### Listar Transferências

```csharp
var transfers = await _asaasService.ListTransfers();

foreach (var transfer in transfers.Data)
{
    Console.WriteLine($"Transferência: {transfer.Value:C} - Status: {transfer.Status}");
}
```

## 📚 Documentação

### Documentação da API Asaas
- [Documentação Oficial](https://docs.asaas.com/)
- [API Reference](https://docs.asaas.com/reference)
- [Guia de Início Rápido](https://docs.asaas.com/docs/inicio-rapido)

### Documentação do Código
Todos os métodos incluem documentação XML completa em português com:
- Descrição da operação
- Link para documentação oficial da API
- Parâmetros
- Tipo de retorno

Exemplo:
```csharp
/// <summary>
/// Cria um novo cliente.
/// Documentação: https://docs.asaas.com/reference/criar-novo-cliente
/// </summary>
/// <param name="request">Dados do cliente a ser criado.</param>
/// <returns>Resposta contendo os dados do cliente criado.</returns>
public async Task<CustomerResponse> CreateNewCustomer(CustomerRequest request)
```

## 🧪 Testes

A biblioteca inclui uma suíte abrangente de testes unitários e de integração.

### Executar Todos os Testes

```bash
dotnet test
```

### Executar Testes de um Módulo Específico

```bash
dotnet test --filter "FullyQualifiedName~Customer"
```

### Estrutura de Testes

Os testes estão organizados seguindo a mesma estrutura modular:
- `AsaasServiceTests_Customer.cs` - Testes do módulo Customer
- `AsaasServiceTests_Payment.cs` - Testes do módulo Payment
- E assim por diante...

### Cobertura de Testes

A biblioteca possui **88 testes** cobrindo:
- ✅ 81 testes funcionais (passam com sucesso)
- ⚠️ 7 testes de integração (requerem conectividade com API)

### DTOs Testing

Todos os DTOs possuem testes para validar:
- Instanciação
- Configuração de propriedades
- Geração com AutoFixture
- Serialização/Deserialização JSON

## 🏗️ Arquitetura

A biblioteca segue uma arquitetura modular com as seguintes características:

### Partial Classes
A classe `AsaasService` é dividida em múltiplos arquivos usando `partial class`:
- `AsaasService.cs` - Configuração base
- `AsaasService_[Module].cs` - Endpoints específicos por módulo

### Estrutura de DTOs
```
DTO/
├── [Module]/
│   ├── Request/
│   │   └── [Entity]Request.cs
│   └── Response/
│       └── [Entity]Response.cs
```

### Serialização
- **Requests**: camelCase, formato de data `yyyy-MM-dd`, ignora valores nulos
- **Responses**: Parsing flexível de datas e propriedades

### Autenticação
A autenticação é feita automaticamente via header `access_token` usando o token configurado na variável de ambiente `ASAAS_TOKEN`.

## 🤝 Contribuindo

Contribuições são bem-vindas! Para contribuir:

1. Fork o repositório
2. Crie uma branch para sua feature (`git checkout -b feature/MinhaFeature`)
3. Commit suas mudanças (`git commit -m 'Adiciona MinhaFeature'`)
4. Push para a branch (`git push origin feature/MinhaFeature`)
5. Abra um Pull Request

### Diretrizes de Contribuição

- Siga os padrões de código existentes
- Adicione testes para novas funcionalidades
- Atualize a documentação conforme necessário
- Use mensagens de commit descritivas em português
- Mantenha a documentação XML em português

### Reportar Problemas

Para reportar bugs ou sugerir melhorias, abra uma [issue](https://github.com/zdzcode-projects/ZDZCode.Payments.Asaas/issues) no GitHub.

## 📄 Licença

Este projeto está licenciado sob os termos especificados no arquivo [LICENSE.md](license.md).

Copyright © ZDZCode Tecnologia da Informação Ltda

## 🔗 Links Úteis

- [Site Oficial do Asaas](https://www.asaas.com)
- [Portal do Desenvolvedor Asaas](https://docs.asaas.com)
- [Sandbox do Asaas](https://sandbox.asaas.com)
- [ZDZCode](https://github.com/zdzcode-projects)

## 📞 Suporte

Para questões relacionadas à biblioteca:
- Abra uma [issue no GitHub](https://github.com/zdzcode-projects/ZDZCode.Payments.Asaas/issues)

Para questões relacionadas à API Asaas:
- Consulte a [documentação oficial](https://docs.asaas.com)
- Entre em contato com o [suporte do Asaas](https://www.asaas.com/suporte)

## 🎯 Roadmap

- [ ] Adicionar suporte para retry automático em falhas de rede
- [ ] Implementar cache para reduzir chamadas repetidas
- [ ] Adicionar exemplos para todos os módulos
- [ ] Criar biblioteca de webhooks helpers
- [ ] Suporte para .NET 9.0

---

Desenvolvido com ❤️ pela equipe [ZDZCode](https://github.com/zdzcode-projects)