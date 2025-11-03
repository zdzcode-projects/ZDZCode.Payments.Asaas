# Guia de Implementação para Agente de IA - ZDZCode.Payments.Asaas

Este documento fornece instruções detalhadas para um agente de IA implementar endpoints faltantes, criar testes unitários e manter a estrutura de código da ZDZCode.

## 📋 Visão Geral do Projeto

O projeto **ZDZCode.Payments.Asaas** é uma biblioteca .NET 8.0 que integra com a API do Asaas (sistema de pagamentos brasileiro). A biblioteca segue os padrões da ZDZCode e está estruturada de forma modular.

### Estrutura de Diretórios

```
ZDZCode.Payments.Asaas/
├── ZDZCode.Payments.Asaas/           # Biblioteca principal
│   ├── AsaasService.cs               # Classe principal (partial)
│   ├── AsaasService_*.cs             # Módulos por funcionalidade
│   ├── DTO/                          # Data Transfer Objects
│   │   ├── [Module]/                 # Um diretório por módulo
│   │   │   ├── Request/              # DTOs de requisição
│   │   │   └── Response/             # DTOs de resposta
│   ├── Commum/                       # Classes comuns
│   ├── ValueObject/                  # Value objects
│   └── DataListResponse/             # Respostas de listagem
│
└── ZDZCode.Payments.Asaas.Tests/     # Projeto de testes
    ├── AsaasServiceTests.cs          # Classe de teste principal (partial)
    ├── AsaasServiceTests_*.cs        # Testes por módulo
    ├── Common/                       # Classes base de teste
    └── Data/                         # Dados de teste
        └── [Module]/                 # Dados por módulo
```

## 🏗️ Arquitetura e Padrões

### 1. Classe AsaasService (Partial Classes)

A classe `AsaasService` é dividida em múltiplos arquivos usando `partial class`:

- **AsaasService.cs**: Configuração base, autenticação, serialização
- **AsaasService_[Module].cs**: Endpoints específicos por módulo (Customer, Payment, Pix, etc.)

**Exemplo de estrutura:**

```csharp
// AsaasService_Customer.cs
using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Customer.Request;
using ZDZCode.Payments.Asaas.DTO.Customer.Response;
using ZDZCode.Payments.Asaas.ValueObject;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        // Métodos do módulo Customer
    }
}
```

### 2. Métodos HTTP

A classe base `HttpServiceBase` fornece métodos para chamadas HTTP:

- `PostAsync<T>(string endpoint, object request)` - POST com resposta tipada
- `GetAsync<T>(string endpoint, object request = null)` - GET com resposta tipada
- `PutAsync<T>(string endpoint, object request)` - PUT com resposta tipada
- `DeleteAsync<T>(string endpoint, object request = null)` - DELETE com resposta tipada

### 3. Padrões de Nomenclatura

#### Métodos de Service:
- **Create/Post**: `CreateNew[Entity]`, `Create[Entity]`
- **List**: `GetList[Entities]`, `List[Entities]`
- **Get Single**: `Get[Entity]ById`, `GetRetrieveASingle[Entity]`
- **Update**: `Update[Entity]`, `UpdateExisting[Entity]`
- **Delete**: `Remove[Entity]`, `Delete[Entity]`
- **Restore**: `Restore[Entity]`, `RestoreRemoved[Entity]`
- **Actions**: Use verbos descritivos, ex: `ReceivePaymentInCash`, `TokenizeCreditCard`

#### DTOs:
- **Request**: `[Entity]Request`, `Create[Entity]Request`, `Update[Entity]Request`
- **Response**: `[Entity]Response`, `List[Entities]Response`, `Delete[Entity]Response`

### 4. Documentação XML

Todos os métodos públicos devem ter documentação XML em português:

```csharp
/// <summary>
/// Cria um novo cliente no Asaas.
/// </summary>
public async Task<CustomerResponse> CreateNewCustomer(CustomerRequest request)
{
    return await PostAsync<CustomerResponse>("/customers", request);
}
```

### 5. Request/Response Models

#### Request Models
```csharp
namespace ZDZCode.Payments.Asaas.DTO.Customer.Request
{
    public class CustomerRequest
    {
        public string Name { get; set; }
        public string CpfCnpj { get; set; }
        public string Email { get; set; }
        // ... outras propriedades
    }
}
```

#### Response Models
```csharp
namespace ZDZCode.Payments.Asaas.DTO.Customer.Response
{
    public class CustomerResponse
    {
        public string Object { get; set; }
        public string Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Name { get; set; }
        // ... outras propriedades
    }
}
```

### 6. Listagem Paginada

Para endpoints que retornam listas, use `ListPageResponse<T>`:

```csharp
public async Task<ListPageResponse<ListCustomersResponse>> GetListCustomers(BaseAsaasRequest request = null)
{
    return await GetAsync<ListPageResponse<ListCustomersResponse>>("/customers/", request);
}
```

## 🧪 Padrões de Testes

### 1. Estrutura de Testes

Os testes seguem a mesma estrutura modular:

```csharp
// AsaasServiceTests_Customer.cs
using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.Customer.Request;

namespace ZDZCode.Payments.Asaas.Tests
{
    public partial class AsaasServiceTests
    {
        [Fact]
        public async Task PostCreatedNewCustomer()
        {
            var request = new CustomerRequest            
            {
                Name = "John Doe",
                CpfCnpj = "24971563792",
                Email = "john.doe@asaas.com.br",
                // ... propriedades necessárias
            };

            var result = await _asaasService.CreateNewCustomer(request);

            result.Should().NotBeNull();
        }
    }
}
```

### 2. Ferramentas de Teste

- **xUnit**: Framework de testes
- **FluentAssertions**: Asserções fluentes
- **AutoFixture**: Geração de dados de teste
- **Moq**: Mocking (quando necessário)

### 3. Padrões de Nomenclatura de Testes

- Use nomes descritivos que indiquem o que está sendo testado
- Padrão: `[HttpMethod][Action][Entity]`
- Exemplos:
  - `PostCreatedNewCustomer`
  - `GetRetrieveSingleCustomer`
  - `UpdateExistingCustomer`
  - `ListCustomers`
  - `RemoveCustomer`

### 4. Classe Base de Teste

Todos os testes herdam de `BaseAsaasServiceTest`:

```csharp
public partial class AsaasServiceTests : BaseAsaasServiceTest
{
    private readonly Fixture _fixture = new();
    
    public AsaasServiceTests(AsaasService asaasService) : base(asaasService)
    {
    }
}
```

O `_asaasService` está disponível através da classe base.

### 5. Uso do AutoFixture

Para testes que não requerem dados específicos:

```csharp
[Fact]
public void UpdateExistingCustomer()
{
    var requestId = "cus_000006258699";

    var request = _fixture
        .Build<CustomerRequest>()
        .Create();

    var result = _asaasService.UpdateExistingCustomer(requestId, request);

    result.Should().NotBeNull();
}
```

## 📝 Módulos com Implementação Incompleta

Os seguintes módulos têm placeholders (`empty.txt`) e precisam de implementação:

### Módulos com DTOs Faltantes (Request/Response)

1. **AccountDocument** - Request e Response
2. **Accountinfo** - Request
3. **Anticipation** - Request e Response
4. **Bill** - Request e Response
5. **CreditBureauReport** - Request e Response
6. **CreditCard** - Request e Response
7. **Finance** - Request e Response
8. **FinancialTransaction** - Request e Response
9. **FiscalInfo** - Request e Response
10. **Installment** - Request e Response
11. **Invoice** - Request e Response
12. **Notification** - Request e Response
13. **PaymentDocument** - Request e Response
14. **PaymentDunning** - Request e Response
15. **PaymentLink** - Request e Response
16. **PaymentRefund** - Request e Response
17. **PaymentSplit** - Request e Response
18. **PaymentWithSummaryData** - Request e Response
19. **Pix** - Request e Response
20. **PixTransaction** - Request e Response
21. **Subaccount** - Request e Response
22. **Transfer** - Request e Response
23. **Webhook** - Request e Response

**Nota**: A pasta `MobilePhoneRecharge` não tem DTOs, mas o service está implementado. Os DTOs provavelmente estão definidos em outro local ou precisam ser criados.

## 🚀 Processo de Implementação

### Passo 1: Consultar Documentação da API Asaas

1. Acesse a documentação oficial: https://docs.asaas.com/
2. Identifique os endpoints do módulo
3. Documente os campos de Request e Response

### Passo 2: Criar DTOs

#### Para Request:
```csharp
// DTO/[Module]/Request/[Entity]Request.cs
namespace ZDZCode.Payments.Asaas.DTO.[Module].Request
{
    public class [Entity]Request
    {
        // Propriedades baseadas na documentação da API
        public string Property1 { get; set; }
        public int? Property2 { get; set; }  // Nullable para propriedades opcionais
        public DateTime? Property3 { get; set; }
    }
}
```

#### Para Response:
```csharp
// DTO/[Module]/Response/[Entity]Response.cs
namespace ZDZCode.Payments.Asaas.DTO.[Module].Response
{
    public class [Entity]Response
    {
        public string Object { get; set; }  // Geralmente presente
        public string Id { get; set; }       // Geralmente presente
        public DateTime DateCreated { get; set; }  // Geralmente presente
        // Outras propriedades da resposta da API
    }
}
```

### Passo 3: Implementar Métodos no Service

```csharp
// AsaasService_[Module].cs
using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.[Module].Request;
using ZDZCode.Payments.Asaas.DTO.[Module].Response;
using ZDZCode.Payments.Asaas.ValueObject;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// [Descrição da operação]
        /// </summary>
        public async Task<[Response]> [MethodName]([Request] request)
        {
            return await PostAsync<[Response]>("/[endpoint]", request);
        }

        // Adicionar outros métodos CRUD conforme necessário
    }
}
```

### Passo 4: Criar Testes Unitários

```csharp
// AsaasServiceTests_[Module].cs
using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.[Module].Request;

namespace ZDZCode.Payments.Asaas.Tests
{
    public partial class AsaasServiceTests
    {
        [Fact]
        public async Task [TestName]()
        {
            // Arrange
            var request = new [Entity]Request
            {
                // Definir propriedades necessárias
            };

            // Act
            var result = await _asaasService.[MethodName](request);

            // Assert
            result.Should().NotBeNull();
            // Adicionar mais asserções conforme necessário
        }
    }
}
```

### Passo 5: Validar Implementação

1. **Build**: `dotnet build ZDZCode.Payments.Asaas.sln --configuration Release`
2. **Testes**: `dotnet test ZDZCode.Payments.Asaas.sln --configuration Release`
3. Verificar warnings e corrigir se necessário

## 📚 Exemplos de Referência

### Exemplo Completo: Customer Module

#### Service (AsaasService_Customer.cs)
```csharp
public partial class AsaasService : HttpServiceBase
{
    public async Task<CustomerResponse> CreateNewCustomer(CustomerRequest request)
    {
        return await PostAsync<CustomerResponse>("/customers", request);
    }

    public async Task<ListPageResponse<ListCustomersResponse>> GetListCustomers(BaseAsaasRequest request = null)
    {
        return await GetAsync<ListPageResponse<ListCustomersResponse>>("/customers/", request);
    }

    public async Task<CustomerResponse> GetRetrieveASingleCustomer(string id, BaseAsaasRequest request = null)
    {
        return await GetAsync<CustomerResponse>($"/customers/{id}", request);
    }

    public async Task<CustomerResponse> UpdateExistingCustomer(string id, CustomerRequest request)
    {
        return await PutAsync<CustomerResponse>($"/customers/{id}", request);
    }

    public async Task<DeleteCustomerResponse> RemoveCustomer(string id, BaseAsaasRequest request = null)
    {
        return await DeleteAsync<DeleteCustomerResponse>($"/customers/{id}", request);
    }

    public async Task<CustomerResponse> RestoreRemovedCustomer(string id, BaseAsaasRequest request = null)
    {
        return await PostAsync<CustomerResponse>($"/customers/{id}/restore", request);
    }
}
```

#### Testes (AsaasServiceTests_Customer.cs)
```csharp
public partial class AsaasServiceTests
{
    [Fact]
    public async Task PostCreatedNewCustomer()
    {
        var request = new CustomerRequest            
        {
            Name = "John Doe",
            CpfCnpj = "24971563792",
            Email = "john.doe@asaas.com.br",
            Phone = "4738010919",
            MobilePhone = "4799376637",
            Address = "Av. Paulista",
            AddressNumber = "150",
            Complement = "Sala 201",
            Province = "Centro",
            PostalCode = "01310-000"
        };

        var result = await _asaasService.CreateNewCustomer(request);

        result.Should().NotBeNull();
    }

    [Fact]
    public async Task ListCustomers()
    {
        var result = await _asaasService.GetListCustomers();

        result.Should().NotBeNull();
    }
}
```

### Exemplo Completo: Payment Module

#### Service (AsaasService_Payment.cs)
```csharp
public partial class AsaasService : HttpServiceBase
{       
    /// <summary>
    /// Cria uma nova cobrança.
    /// </summary>
    public async Task<CreateNewPaymentResponse> CreateNewPayment(CreateNewPaymentRequest request)
    {
        return await PostAsync<CreateNewPaymentResponse>("/payments", request);
    }

    /// <summary>
    /// Lista todas as cobranças.
    /// </summary>
    public async Task<ListPageResponse<ListPaymentsResponse>> GetListPayments(BaseAsaasRequest request = null)
    {
        return await GetAsync<ListPageResponse<ListPaymentsResponse>>("/payments", request);
    }

    /// <summary>
    /// Recupera uma cobrança pelo identificador.
    /// </summary>
    public async Task<CreateNewPaymentResponse> GetPaymentById(string id, BaseAsaasRequest request = null)
    {
        return await GetAsync<CreateNewPaymentResponse>($"/payments/{id}", request);
    }

    /// <summary>
    /// Atualiza uma cobrança existente.
    /// </summary>
    public async Task<CreateNewPaymentResponse> UpdatePayment(string id, CreateNewPaymentRequest request)
    {
        return await PostAsync<CreateNewPaymentResponse>($"/payments/{id}", request);
    }

    /// <summary>
    /// Remove uma cobrança.
    /// </summary>
    public async Task<ValueResponse> DeletePayment(string id, BaseAsaasRequest request = null)
    {
        return await DeleteAsync<ValueResponse>($"/payments/{id}", request);
    }
}
```

## 🔧 Convenções e Boas Práticas

### 1. Serialização JSON

O projeto usa `Newtonsoft.Json` com:
- `CamelCasePropertyNamesContractResolver` para requests
- `DateFormatString = "yyyy-MM-dd"`
- `NullValueHandling = NullValueHandling.Ignore`

**Implicação**: Propriedades C# em PascalCase são automaticamente convertidas para camelCase no JSON.

### 2. Autenticação

A autenticação é feita via header `access_token` automaticamente através do método `BuildHttpClient()`.
A chave da API vem da variável de ambiente `ASAAS_TOKEN`.

### 3. Ambientes

- **Sandbox**: https://sandbox.asaas.com/api/v3
- **Production**: https://api.asaas.com/v3

Controlado pela variável de ambiente `ASPNETCORE_ENVIRONMENT`.

### 4. Parâmetros Opcionais

Use `BaseAsaasRequest` para parâmetros opcionais de query string:

```csharp
public async Task<Response> GetMethod(BaseAsaasRequest request = null)
{
    return await GetAsync<Response>("/endpoint", request);
}
```

### 5. Tipos Nullable

Use tipos nullable (`?`) para propriedades opcionais:

```csharp
public bool? NotificationDisabled { get; set; }
public int? Value { get; set; }
public DateTime? DueDate { get; set; }
```

## ⚠️ Pontos de Atenção

### 1. Warnings Existentes

O projeto tem alguns warnings de nullable reference types. Novos códigos devem seguir o mesmo padrão do código existente.

### 2. Testes de Integração

Os testes atuais são testes de integração que fazem chamadas reais à API do Asaas. Por isso:
- Eles podem falhar se não houver conectividade ou token válido
- Em ambiente de CI/CD, pode ser necessário mockar as respostas

### 3. DTOs Ausentes

Muitos módulos têm apenas placeholders (`empty.txt`). Ao implementá-los:
1. Consulte a documentação oficial da API Asaas
2. Implemente TODOS os campos documentados
3. Use tipos apropriados (string, int, decimal, DateTime, bool, etc.)
4. Considere enums para campos com valores fixos

### 4. Versionamento da API

O projeto usa a versão **v3** da API Asaas. Verifique se a documentação consultada está na versão correta.

## 📊 Checklist de Implementação

Para cada módulo a ser implementado:

- [ ] Estudar documentação da API Asaas para o módulo
- [ ] Criar DTOs de Request com todas as propriedades
- [ ] Criar DTOs de Response com todas as propriedades
- [ ] Implementar métodos no AsaasService_[Module].cs
- [ ] Adicionar documentação XML em português para cada método
- [ ] Criar arquivo AsaasServiceTests_[Module].cs
- [ ] Implementar teste para cada método público
- [ ] Executar build e corrigir erros/warnings
- [ ] Executar testes e validar
- [ ] Remover arquivos `empty.txt` dos diretórios DTO/[Module]/Request e Response

## 🔗 Recursos

- **Documentação Asaas**: https://docs.asaas.com/
- **API Sandbox**: https://sandbox.asaas.com/
- **ZDZCode.ExternalServices**: Biblioteca base da ZDZCode
- **xUnit**: https://xunit.net/
- **FluentAssertions**: https://fluentassertions.com/
- **AutoFixture**: https://github.com/AutoFixture/AutoFixture

## 📝 Notas Finais

Este guia fornece a estrutura completa para implementar novos endpoints e testes seguindo os padrões estabelecidos no projeto ZDZCode.Payments.Asaas. Ao seguir estas diretrizes, você garantirá consistência e qualidade no código.

Para qualquer dúvida ou caso especial não coberto neste guia, consulte os módulos já implementados (Customer, Payment) como referência.
