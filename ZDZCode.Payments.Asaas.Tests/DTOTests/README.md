# Testes Unitários - DTOs Asaas

Este diretório contém testes unitários para os Data Transfer Objects (DTOs) da biblioteca de integração com o Asaas.

## Estrutura dos Testes

### Testes de DTO Implementados

1. **CustomerRequestTests.cs** - 7 testes
   - Validação de propriedades obrigatórias
   - Validação de CPF e CNPJ
   - Múltiplos emails adicionais
   - Notificações desabilitadas

2. **PaymentRequestTests.cs** - 9 testes
   - Diferentes tipos de cobrança (BOLETO, CREDIT_CARD, PIX)
   - Valores decimais
   - Parcelamento
   - Juros e multas
   - Descrições

## Padrão de Teste

Todos os testes seguem o padrão AAA (Arrange-Act-Assert):

```csharp
/// <summary>
/// Descrição do que o teste valida.
/// Documentação: https://docs.asaas.com/reference/...
/// </summary>
[Fact]
public void NomeDoMetodo_Condicao_ResultadoEsperado()
{
    // Arrange - Preparação
    var request = new RequestDTO { ... };
    
    // Act - Ação
    var result = request.Property;
    
    // Assert - Verificação
    result.Should().Be(expectedValue);
}
```

## Tecnologias Utilizadas

- **xUnit**: Framework de testes
- **FluentAssertions**: Assertions legíveis
- **AutoFixture**: Geração de dados de teste

## Executando os Testes

```bash
# Todos os testes de DTO
dotnet test --filter FullyQualifiedName~DTOTests

# Testes específicos de Customer
dotnet test --filter FullyQualifiedName~CustomerRequestTests

# Testes específicos de Payment
dotnet test --filter FullyQualifiedName~PaymentRequestTests
```

## Cobertura

Total de testes de DTO: **16 testes**
- Customer: 7 testes
- Payment: 9 testes

## Próximos Passos

Para expandir a cobertura de testes, adicione novos arquivos de teste para:
- PixRequestTests
- SubscriptionRequestTests
- InvoiceRequestTests
- WebhookRequestTests
- E outros DTOs conforme necessário

Cada arquivo deve seguir o mesmo padrão estabelecido aqui.
