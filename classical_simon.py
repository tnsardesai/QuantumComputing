import numpy as np

def find_diag_idx(W):
    fixed = False
    pos = 0
    for idx, row in enumerate(W):
        if np.all(row[:idx+1] == 0):
            W = list(W)
            new_row = np.zeros(len(row), dtype=int)
            new_row[idx] = 1
            W.insert(idx, new_row)
            fixed = True
            pos = idx
            break
    if not fixed:
        W = list(W)
        new_row = np.zeros(len(row), dtype=int)
        new_row[idx+1] = 1
        pos = idx+1
        W.insert(idx+1, new_row)
    return pos, W

def insert_new_row(W):
    pos, W = find_diag_idx(W)
    return pos, W


def find_solution(eqns):
    from scipy.linalg import lu
    W = np.array(eqns)
    _,_,W = lu(W)
    pos, W = insert_new_row(W)
    b = np.zeros(len(W[0]))
    b[pos] = 1
    return np.linalg.solve(W,b)


print(find_solution([[0,0,1],[1,1,1]]))