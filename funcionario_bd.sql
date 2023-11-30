create database funcionario;
use funcionario;

create table Funcionario (
id_fun int primary key auto_increment,
nome_fun varchar (300) not null,
cpf_fun varchar (100),
rg_fun varchar (100),
estadoCivil_fun varchar (100),
data_nascimento_fun date,
celular_fun varchar (100),
estado_fun varchar (100),
cidade_fun varchar(100),
endereco_fun varchar (300),
email_fun varchar (300),
funcao_fun varchar(100),
salario_fun double
);

INSERT INTO Funcionario(id_fun, nome_fun, cpf_fun, rg_fun, estadoCivil_fun, data_nascimento_fun, celular_fun, estado_fun, cidade_fun, endereco_fun, email_fun, funcao_fun,salario_fun) VALUES();
SELECT * FROM Funcionario;

create table Empresa(
id_emp int primary key auto_increment,
cnpj_emp varchar(20),
razao_social_emp varchar (200),
nome_fant_emp varchar (200),
situacao_cadastral_emp varchar(200),
regime_Tributario_emp varchar(200),
data_inicio_emp date,
telefone_emp varchar (20),
capital_social_emp double,
tipo_emp varchar (200),
porte_empresa_emp varchar (200),
natureza_juridica_emp varchar(200),
nome_prop_emp varchar (200),
cpf_prop_emp varchar (15)
);
alter table Empresa drop mei_emp;

INSERT INTO Empresa(id_emp, cnpj_emp, razao_social_emp, nome_fant_emp, situacao_cadastral_emp, regime_Tributario_emp, data_inicio_emp, telefone_emp, capital_social_emp, tipo_emp, porte_empresa_emp, natureza_juridica_emp, nome_prop_emp, cpf_prop_emp) VALUES();
SELECT * FROM Empresa; 

