import numpy as np
import itertools

def create_Zf(f, bits):
    dim = 2**bits
    Zf = np.eye(dim, dtype=int)
    lst_bitseq = list(map(list, itertools.product([0, 1], repeat=bits)))
    for col, bitseq in enumerate(lst_bitseq):
        if f(bitseq) == 1:
            Zf[col, col] = -1
            break
    return Zf

def create_Z0(bits):
    dim = 2**bits
    Z0 = np.eye(dim, dtype=int)
    Z0[0,0] = -1
    return Z0

def num_iters(bits):
    return np.floor((np.pi/4)*np.sqrt(2**bits))


def main():
    print(create_Z0(2))
    print(create_Zf((lambda x: 1 if x == [1,0] else 0), 2))

main()
