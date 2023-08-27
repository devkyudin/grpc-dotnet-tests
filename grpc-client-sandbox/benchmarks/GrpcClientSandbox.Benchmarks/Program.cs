using BenchmarkDotNet.Running;
using GrpcClientSandbox.Benchmarks.Tests;

namespace GrpcClientSandbox.Benchmarks;

public static class Program
{
	// https://benchmarkdotnet.org/
	public static void Main(string[] args)
	{
		BenchmarkRunner.Run<GrpcClientSandboxTests>();
	}
}