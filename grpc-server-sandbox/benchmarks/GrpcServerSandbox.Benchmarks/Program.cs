using BenchmarkDotNet.Running;
using GrpcServerSandbox.Benchmarks.Tests;

namespace GrpcServerSandbox.Benchmarks;

public static class Program
{
	// https://benchmarkdotnet.org/
	public static void Main(string[] args)
	{
		BenchmarkRunner.Run<GrpcServerSandboxTests>();
	}
}