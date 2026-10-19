# Cafeteria Dev

Sistema desktop em **C# Windows Forms (.NET)** para gestão de uma cafeteria, desenvolvido como Checkpoint 2 da disciplina de C# Development (FIAP - 3ESPS).

## Estrutura de Telas

- **Tela de Splash** — Abertura / Carregamento
- **Tela de Menu** — Principal / Navegação
- **Tela de Venda do Café** — Lançamento de pedidos
- **Tela de Relatório de Vendas** — Listagem e visualização de dados

## Fluxo Git

- `main` — branch estável
- `dev` — branch de integração
- `feature/*` — branches de tarefa (uma por dev)

Toda feature branch abre **Pull Request contra `dev`**. Mínimo de **3 commits semânticos** por tarefa.

## Divisão da Equipe

| Papel | Integrante | Responsabilidade |
|-------|-----------|-------------------|
| Tech Lead | — | Setup do repo, Tela Splash + Tela Menu, Code Review, `integrantes.txt` |
| Dev 1 | @igorNociti | Tela de Venda do Café (`feature/tela-vendas`) |
| Dev 2 | @henriquemacielr | Tela de Relatório de Vendas (`feature/tela-relatorios`) |

## Padrão de Commits Semânticos
feat(ui): cria estrutura inicial do formulario de vendas
feat(logic): adiciona logica de calculo de pedidos
model(pedido): implementa classe de modelo
fix(menu): corrige navegacao entre telas
docs: atualiza README

