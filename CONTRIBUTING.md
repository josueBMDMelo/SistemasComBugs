# Diretrizes de Contribuição

Obrigado por contribuir com este projeto. Para manter consistência e qualidade, siga as seções abaixo.

## Como Contribuir

1. Abra uma issue descrevendo a mudança proposta antes de começar a trabalhar.
2. Crie uma branch a partir de `main` com o padrão `feature/<descrição>` ou `fix/<descrição>`.
3. Faça commits pequenos e atômicos com mensagens no estilo: `tipo: escopo - breve descrição` (ex.: `feat: form - adicionar validação de preço`).
4. Abra um Pull Request descrevendo a mudança, com screenshots se aplicável.

## Padrões de Código

- Siga as regras definidas em `.editorconfig`.
- Use blocos de namespace (não file-scoped) — consistência com o código existente.
- Evite `var` quando o tipo não for aparente.
- Prefira nomes claros e em inglês quando possível; elementos de UI podem usar português.

## Revisão de PR

- Inclua uma descrição clara do que foi alterado.
- Adicione testes quando aplicável.
- Um revisor deve aprovar o PR antes do merge.

## Branching e Releases

- Branch padrão: `main`.
- Merges para `main` devem ser feitos via Pull Request com revisão.

## Licença

Certifique-se de que a contribuição esteja de acordo com a licença do repositório.
