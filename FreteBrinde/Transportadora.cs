﻿using System;

public class Transportadora
{
	public Transportadora()
	{
	private double valorFixo;
	private double valorKM;
	private String nome;

	public Transportadora(double valorFixo, double valorKM, String nome)
	{
		this.valorFixo = valorFixo;
		this.valorKM = valorKM;
		this.nome = nome;

	}

	public double getValorFixo()
	{
		return valorFixo;
	}

	public void setValorFixo(double valorFixo)
	{
		this.valorFixo = valorFixo;
	}

	public double getValorKM()
	{
		return valorKM;
	}

	public void setValorKM(double valorKM)
	{
		this.valorKM = valorKM;
	}

	public String getNome()
	{
		return nome;
	}

	public void setNome(String nome)
	{
		this.nome = nome;
	}

	public void calculaFrete(int distancia, int peso)
	{
		double custo = this.valorFixo + (peso * distancia * this.valorKM);
		System.out.println("Transportadora " + this.nome + " tem o custo e de R$" + custo);

	}
}
	

