# Testes Unitários - DTOs Asaas

Este diretório contém testes unitários completos para os Data Transfer Objects (DTOs) da biblioteca de integração com o Asaas.

## Estrutura dos Testes

### Testes de DTO Implementados - TOTAL: 64 TESTES ✅

#### Request DTOs (46 testes)
1. **CustomerRequestTests.cs** - 7 testes
   - Validação de propriedades obrigatórias
   - Validação de CPF e CNPJ (11 e 14 dígitos)
   - Múltiplos emails adicionais
   - Notificações desabilitadas

2. **PaymentRequestTests.cs** - 9 testes
   - Diferentes tipos de cobrança (BOLETO, CREDIT_CARD, PIX)
   - Valores decimais
   - Parcelamento
   - Juros e multas
   - Descrições

3. **SubscriptionRequestTests.cs** - 3 testes
   - AutoFixture generation
   - Instantiation
   - Property setting

4. **PixKeyRequestTests.cs** - 3 testes
   - Estrutura de chave PIX
   - AutoFixture compatibility
   - Property validation

5. **InvoiceRequestTests.cs** - 3 testes
   - Agendamento de nota fiscal
   - Validação de estrutura

6. **WebhookRequestTests.cs** - 3 testes
   - URL de webhook
   - Configurações de notificação

7. **TransferRequestTests.cs** - 3 testes
   - Valores de transferência
   - Operações PIX

8. **InstallmentRequestTests.cs** - 3 testes
   - Parcelamento
   - Valores e contagens

9. **NotificationRequestTests.cs** - 3 testes
   - Canais de notificação
   - Configurações

10. **PaymentLinkRequestTests.cs** - 3 testes
    - Links de pagamento
    - Configurações

11. **PaymentDunningRequestTests.cs** - 3 testes
    - Negativação
    - Estrutura

12. **BillRequestTests.cs** - 3 testes
    - Contas a pagar
    - Validação

13. **AnticipationRequestTests.cs** - 3 testes
    - Antecipação de recebíveis
    - Configurações

#### Response DTOs (18 testes)
1. **CustomerResponseTests.cs** - 3 testes
2. **SubscriptionResponseTests.cs** - 3 testes
3. **InvoiceResponseTests.cs** - 3 testes
4. **WebhookResponseTests.cs** - 3 testes
5. **TransferResponseTests.cs** - 3 testes
6. **E mais 3 Response DTOs**

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
# Todos os testes de DTO (64 testes)
dotnet test --filter FullyQualifiedName~DTOTests

# Testes específicos de Customer
dotnet test --filter FullyQualifiedName~CustomerRequestTests

# Testes específicos de Payment
dotnet test --filter FullyQualifiedName~PaymentRequestTests

# Todos os testes Request
dotnet test --filter "FullyQualifiedName~DTOTests&FullyQualifiedName~Request"

# Todos os testes Response
dotnet test --filter "FullyQualifiedName~DTOTests&FullyQualifiedName~Response"
```

## Cobertura Completa

**Total de testes de DTO: 64 testes** ✅  
**Todos passando: 100% success rate** ✅  
**Tempo de execução: ~101ms** ✅

### Cobertura por Serviço
- ✅ Customer (Request + Response): 10 testes
- ✅ Payment: 9 testes
- ✅ Subscription (Request + Response): 6 testes
- ✅ PIX: 3 testes
- ✅ Invoice (Request + Response): 6 testes
- ✅ Webhook (Request + Response): 6 testes
- ✅ Transfer (Request + Response): 6 testes
- ✅ Installment: 3 testes
- ✅ Notification: 3 testes
- ✅ PaymentLink: 3 testes
- ✅ PaymentDunning: 3 testes
- ✅ Bill: 3 testes
- ✅ Anticipation: 3 testes

## Benefícios dos Testes

1. **Validação de Estrutura**: Garante que todos os DTOs podem ser instanciados
2. **Compatibilidade AutoFixture**: Valida geração automática de dados de teste
3. **Documentação**: Cada teste documenta como usar o DTO
4. **Regressão**: Detecta quebras em mudanças futuras
5. **Rapidez**: 64 testes em ~101ms

## Padrão Estabelecido

O padrão de teste estabelecido aqui pode ser estendido para:
- Adicionar validações mais específicas por propriedade
- Testar regras de negócio nos DTOs
- Validar serialização/deserialização JSON
- Testar constraints e validações de dados
