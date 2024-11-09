# Procedural

## Comandos

- `ls`: lista os arquivos na pasta
- `cd NomeDaPasta/`: entra na pasta
- `cd ..`: volta uma pasta atras

## Variáveis

```cs
long id = 123L;
int idade = 23;
double altura = 1.8;
string nome = "Pedro";
bool sabeVoar = false;
```

## Console

```cs
// Le uma linha digitada pelo usuario
Console.ReadLine();

// Imprime algo na tela
Console.WriteLine("Hello World");
```

## Conversões

```cs
int idade = int.Parse(Console.ReadLine());
double altura = double.Parse(Console.ReadLine());
bool sabeVoar = bool.Parse(Console.ReadLine());
```

## If...Else

```cs
double nota = 7.8;

if (nota > 7.0) {
  Console.WriteLine("aprovado");
} else {
  Console.WriteLine("recuperacao");
}

bool estaChovendo = false;

if (estaChovendo) {
  Console.WriteLine("vou ficar em casa");
}
```

- `&&` (and/e): serve para validar uma coisa e outra (precisa que as duas sejam verdadeiras)
- `||` (or/ou): serve para valida uma coisa ou outra (precisa que pelo menos uma seja verdadeira)

```cs
if (temAgua) {
  if (temCafe) {
    // posso fazer cafe
  }
}

if (temAgua && temCafe) {

}

// ------

if (temMaca) {

} else if (temMorango) {

}

if (temMaca || temMorango) {

}
```

```java
// se o aluno tira 7.0 ou mais -> aprovado
// se tira 4.0 ou mais e menos que 7 -> recuperacao
// se tira menos que 4 -> reprovado

double nota = 6.5;

if (nota >= 7.0) {
  Console.WriteLine("Aprovado");
} else if (nota >= 4.0) {
  Console.WriteLine("Recuperacao");
} else {
  Console.WriteLine("Reprovado");
}
```
