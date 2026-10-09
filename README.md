# Projetos e Atividades de Linguagem de Programação 2 (LP2)

Repositório dedicado ao armazenamento e organização das atividades, exercícios e projetos práticos desenvolvidos na disciplina de **Linguagem de Programação 2 (LP2)** do curso de Tecnologia em Análise e Desenvolvimento de Sistemas (FATEC), utilizando **C#** e o ecossistema **.NET**.

---

## 📁 Estrutura de Pastas

O repositório está organizado em diretórios por atividade, avaliação e projeto final. A solução (`.sln`) encontra-se diretamente na pasta da atividade e os arquivos de código-fonte no diretório do projeto (`.csproj`):

```
LP2/
├── Atividade 1/
│   ├── Pvolume.sln               # Solução Visual Studio
│   └── Pvolume/                  # Projeto C# (Cálculo de volume - Windows Forms)
├── Atividade 2/
│   ├── Pcalc.sln                 # Solução Visual Studio
│   └── Pcalc/                    # Projeto C# (Calculadora básica de operações)
├── Atividade 3/
│   ├── Pimc.sln                  # Solução Visual Studio
│   └── Pimc/                     # Projeto C# (Cálculo e classificação de IMC)
├── Atividade 4/
│   ├── Ptriangulo.sln            # Solução Visual Studio
│   └── Ptriangulo/               # Projeto C# (Classificação e verificação de triângulos)
├── Atividade 5/
│   ├── PTesteMetodod.sln         # Solução Visual Studio
│   └── PTesteMetodod/            # Projeto C# (Métodos e manipulação de strings)
├── Atividade 6/
│   ├── PClasses.sln              # Solução Visual Studio
│   └── PClasses/                 # Projeto C# (POO - Classes Empregado, Horista, Mensalista)
├── Atividade 7/
│   ├── Ploops.sln                # Solução Visual Studio
│   └── Ploops/                   # Projeto C# (Estruturas de repetição: while, for, do-while)
├── Atividade 8/
│   ├── Parray.sln                # Solução Visual Studio
│   └── Parray/                   # Projeto C# (Operações com vetores e matrizes)
├── Certificados/
│   └── certificadoReact.jpg      # Certificados complementares
├── Projeto Final/
│   ├── PFerramentas0030482423057.sln # Solução Visual Studio
│   └── PFerramentas0030482423057/    # Projeto C# (Sistema CRUD de Ferramentas, Categorias e Fabricantes)
└── Prova/
    ├── PAluno02.sln              # Solução Visual Studio
    └── PAluno02/                 # Projeto C# (Avaliação prática da disciplina)
```

---

## 🚀 Como Executar

### Pré-requisitos
- **Visual Studio 2019/2022** com o pacote de carga de trabalho **Desenvolvimento para desktop com .NET** (.NET Framework 4.8 / Windows Forms), ou:
- **.NET SDK** instalado (para suporte via CLI).

### Opção 1: Visual Studio (Recomendado)
1. Navegue até a pasta da atividade desejada.
2. Abra o arquivo de solução com extensão `.sln` localizado na raiz da atividade (por exemplo, `Atividade 1/Pvolume.sln` ou `Atividade 2/Pcalc.sln`).
3. Aguarde o carregamento do projeto e pressione `F5` (ou o botão **Iniciar**) para compilar e executar com interface gráfica.

### Opção 2: Visual Studio Code
1. Abra a pasta do projeto no VS Code (`code .`).
2. Utilize a extensão oficial **C# Dev Kit** / **C#** para suporte à linguagem.
3. Utilize o Solution Explorer do VS Code para navegar pelos projetos e executá-los.

### Opção 3: Terminal / .NET CLI
Navegue até a pasta do projeto que contém o arquivo `.csproj` e utilize os comandos da CLI:

```bash
# Compilar o projeto
dotnet build

# Executar a aplicação
dotnet run
```

*Nota: Para soluções direcionadas ao .NET Framework tradicional no Windows, a compilação também pode ser efetuada via Developer Command Prompt do Visual Studio utilizando `msbuild`.*
